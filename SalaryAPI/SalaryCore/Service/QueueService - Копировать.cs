using DataLayer.Abstract;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using SalaryCore.Contracts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using DataLayer.Entities.Models;
using Microsoft.EntityFrameworkCore.Storage;

namespace SalaryCore.Service
{
    public class QueueService2 : IHostedService, IDisposable
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly HttpClient _httpClient;
        private Timer _timer;

        public QueueService2(IServiceScopeFactory scopeFactory, HttpClient httpClient) =>
            (_scopeFactory, _httpClient) = (scopeFactory, httpClient);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromMinutes(10));
            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            IDbContextTransaction transaction = null;
            try
            {
                using var scope = _scopeFactory.CreateScope();
                var repository = scope.ServiceProvider.GetRequiredService<IRepository>();

                var dateStart = DateTime.Now;

                var mfc = repository.SprEmployeesMfcs
                    .Where(w=>w.SprQueueJoinMfcs.Any())
                    .Select(s => new QueueMfc
                    {
                        MfcId = s.Id, 
                        MfcQueueId = (int)s.SprQueueJoinMfcs.First().SprMfcId,
                        MfcName = s.MfcName,
                        CountActiveOperator = s.SprEmployeesMfcJoins.Where(w=> w.DateStart < DateTime.Now && (w.DateStop == null || w.DateStop > DateTime.Now)
                         &&w.SprEmployeesRoleJoins.Any(aa => aa.SprEmployeesRoleId == 3 && aa.DateStart < DateTime.Now && (aa.DateStop == null || aa.DateStop > DateTime.Now)))
                        .Sum(ss=>ss.SprEmployees.SprEmployeesAuthorizationLogs.Count(c => c.LogInDate.Date == DateTime.Now.Date))
                    })
                    .ToList();

                Dictionary<QueueMfc, QueueInfo> dataQueue = new(mfc.Count);
                var id = Guid.NewGuid();
                List<ApiManagerPanelQueueInfo> dataQueueOffices = new(mfc.Count);
                var dateRequest = new ApiManagerPanelQueue{Id = id, DateQuery = dateStart};
               
                mfc.ForEach(f =>
                {
                    var a = $"//192.168.34.196:82/api/ais/offices/{f.MfcQueueId}/status/";

                    var request = new HttpRequestMessage(HttpMethod.Get, $"http:{a}")
                    {
                        Content = new StringContent(string.Empty,
                            System.Text.Encoding.UTF8,
                            "application/json")
                    };
                    var response = _httpClient.Send(request);
                    if (!response.IsSuccessStatusCode)
                    {
                        var temp = new QueueInfo();
                        dataQueue.Add(f, temp);
                        return;
                    }
                    
                    var b = response.Content.ReadAsStringAsync().Result;

                    var qts = JsonConvert.DeserializeObject<QueueInfo>(b);

                    if (qts is null)
                    {
                        var temp = new QueueInfo();
                        dataQueue.Add(f, temp);
                        return;
                    }

                    dataQueue.Add(f, qts);

                });

               
                foreach (var (key, queue) in dataQueue)
                {
                    dataQueueOffices.Add(new ApiManagerPanelQueueInfo
                    {
                        ApiManagerPanelQueueId = dateRequest.Id,
                        SprEmployeesMfcId = key.MfcId,
                        MfcName = key.MfcName,
                        MfcId = key.MfcQueueId,
                        AverageWaitingTime = queue.waiting_time_in_queue_average,
                        CountWorkWindows = queue.work_windows,
                        MinWaitTime = queue.waiting_time_in_queue_minimum,
                        MaxWaitTime = queue.waiting_time_in_queue_maximum,
                        CountCustomerLong = queue.waiting_long_time_in_queue_number,
                        CountCustomerLittle = queue.waiting_normal_time_in_queue_number,
                        CountActiveOperator = key.CountActiveOperator,
                    });
                }

             
                dateRequest.CountWorkWindows = dataQueueOffices.Where(w => w.CountWorkWindows.HasValue).Sum(x => x.CountWorkWindows.Value);
                dateRequest.CountCustomerLong = dataQueueOffices.Where(w => w.CountCustomerLong.HasValue).Sum(x => x.CountCustomerLong.Value);
                dateRequest.CountCustomerLittle = dataQueueOffices.Where(w => w.CountCustomerLittle.HasValue).Sum(x => x.CountCustomerLittle.Value);
                dateRequest.CountActiveOperator = dataQueueOffices.Where(w => w.CountActiveOperator.HasValue).Sum(x => x.CountActiveOperator.Value);
                dateRequest.AverageWaitingTime = TimeSpan.FromSeconds(dataQueueOffices.Where(w => w.AverageWaitingTime.HasValue).Average(x => x.AverageWaitingTime.Value.TotalSeconds));
                dateRequest.MinWaitTime = dataQueueOffices.Min(x => x.MinWaitTime);
                dateRequest.MaxWaitTime = dataQueueOffices.Max(x => x.MaxWaitTime);
                dateRequest.DateAnswer = DateTime.Now;

                transaction = repository.BeginTransaction();
                
                repository.Insert(dateRequest);
                repository.Inserts(dataQueueOffices);
                
                transaction.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                transaction?.Rollback();
                throw;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
