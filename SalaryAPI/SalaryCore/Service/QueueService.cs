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
    public class QueueService : IHostedService, IDisposable
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly HttpClient _httpClient;
        private Timer _timer;

        public QueueService(IServiceScopeFactory scopeFactory, HttpClient httpClient) =>
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

                var mfc = repository.SprQueueJoinMfcs
                    .Select(s => new QueueMfc {  MfcId = (Guid)s.SprEmployeesMfc, MfcName = s.SprEmployeesMfcNavigation.MfcName, MfcQueueId = (int)s.SprMfcId })
                    .ToList();

                Dictionary<QueueMfc, QueueInfo> dataQueue = new(mfc.Count);

                var dateStart = DateTime.Now;

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
                
                transaction = repository.BeginTransaction();

                var dateRequest = new ApiManagerPanelQueue
                {
                    DateQuery = dateStart,
                    DateAnswer = DateTime.Now
                };
                repository.Insert(dateRequest);

                foreach (var (key, queue) in dataQueue)
                {
                    repository.Insert(new ApiManagerPanelQueueInfo
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
                        CountCustomerLittle = queue.waiting_normal_time_in_queue_number
                    });
                }

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
