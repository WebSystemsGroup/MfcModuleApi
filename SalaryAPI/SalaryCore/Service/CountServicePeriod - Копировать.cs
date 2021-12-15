using DataLayer.Abstract;
using DataLayer.Entities.Models;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SalaryCore.Service
{
    public class CountServicePeriod2 : IHostedService, IDisposable
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private Timer _timer;

        public CountServicePeriod2(IServiceScopeFactory scopeFactory) => _scopeFactory = scopeFactory;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromHours(24));
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
                var dateStart = DateTime.Now;

                using var scope = _scopeFactory.CreateScope();
                var repository = scope.ServiceProvider.GetRequiredService<IRepository>();

                var servicePeriod =
                    repository.ApiManagerPanelServiceDates.FirstOrDefault(f=>f.DateQuery.Date==DateTime.Now.Date);

                if (servicePeriod is not null) return;

                List<ApiManagerPanelServicePeriod> servicePeriodOffices = new List<ApiManagerPanelServicePeriod>();
                var id = Guid.NewGuid();

                var dateRequest = new ApiManagerPanelServiceDate {Id = id, DateQuery = dateStart};

                var receivedCountMonth = 0;
                var executedCountMonth = 0;
                var countExecutionService = 0;
                var countExpiredService = 0;
                var countExpiredStages = 0;
                var countExecutionStages = 0;

                var dataOffice =  repository.SprEmployeesMfcs.Where(w => (bool)!w.StructuralSubdivision).Select(s => new
                {
                    s.Id,
                    receivedCountMonth = s.DataReportReceiveds.Where(w => w.Date >= DateTime.Now.AddMonths(-1)).Sum(x => x.Count),
                    //receivedCountWeek = s.DataReportReceiveds.Where(w => w.Date >= DateTime.Now.AddDays(-7)).Sum(x => x.Count),
                    //receivedCountQuarter = s.DataReportReceiveds.Where(w => w.Date >= DateTime.Now.AddMonths(-3)).Sum(x => x.Count),
                    //receivedCountYear = s.DataReportReceiveds.Where(w => w.Date >= DateTime.Now.AddYears(-1)).Sum(x => x.Count),
                    executedCountMonth = s.DataReportReceiveds.Where(w => w.Date >= DateTime.Now.AddMonths(-1)).Sum(x => x.Count),
                    //executedCountWeek = s.DataReportReceiveds.Where(w => w.Date >= DateTime.Now.AddDays(-7)).Sum(x => x.Count),
                    //executedCountQuarter = s.DataReportReceiveds.Where(w => w.Date >= DateTime.Now.AddMonths(-3)).Sum(x => x.Count),
                    //executedCountYear = s.DataReportReceiveds.Where(w => w.Date >= DateTime.Now.AddYears(-1)).Sum(x => x.Count),
                    countExpiredService = s.DataServiceSprEmployeesMfcs.Count(c => c.SprServicesSubStatusId == 0 && c.DateFinishTotal > DateTime.Now),
                    countExpiredStages = s.DataServicesRoutesStages.Count(c => c.DataServices.SprServicesSubStatusId == 0 && c.DateFinishReg < c.DateFinishFact || (c.DateFinishReg < DateTime.Now && c.DateFinishFact == null)),
                    countExecutionService = s.DataServiceSprEmployeesMfcs.Count(c => c.SprServicesSubStatusId == 0 && c.DateFinishFact == null),
                    countExecutionStages = s.DataServicesRoutesStages.Count(c => c.DataServices.SprServicesSubStatusId == 0 && c.DateFinishFact == null)
                })
                .ToList();

                //var serviceCount =  repository.DataServices.Count(c => c.DateFinishFact == null);

                dataOffice.ForEach(f => {

                receivedCountMonth += f.receivedCountMonth;
                executedCountMonth += f.executedCountMonth;
                countExecutionService += f.countExecutionService;
                countExpiredService += f.countExpiredService;
                countExpiredStages += f.countExpiredStages;
                countExecutionStages += f.countExecutionStages;

                servicePeriodOffices.Add(new ApiManagerPanelServicePeriod
                {
                    SprEmployeesMfcId = f.Id,
                    CountExecutedWeek = 0,
                    CountExecutedMonth = 0,
                    CountExecutedQuarter = 0,
                    CountExecutedYear = 0,
                    CountReceivedWeek = 0,
                    CountReceivedMonth = f.receivedCountMonth,
                    CountReceivedQuarter = 0,
                    CountReceivedYear = 0,
                    CountExpired = f.countExpiredService,
                    PercentExpired = 0,
                    CountExpiredStage = f.countExpiredStages,
                    PercentExpiredStage = 0,
                    CountExecutionService = f.countExecutionService,
                    CountExecutionStage = f.countExecutionStages,
                    ApiManagerPanelServiceDateId = dateRequest.Id
                });
                });

                dateRequest.DateAnswer = DateTime.Now;
                dateRequest.ReceivedCountMonth = receivedCountMonth;
                dateRequest.ExecutedCountMonth = executedCountMonth;
                dateRequest.CountExecutionService = countExecutionService;
                dateRequest.CountExpiredService = countExpiredService;
                dateRequest.CountExpiredStages = countExpiredStages;
                dateRequest.PercentExpiredService = Math.Round((decimal)countExpiredService / (decimal)countExecutionService * 100, 2);
                dateRequest.PercentExpiredStages = Math.Round((decimal)countExpiredStages / (decimal)countExecutionStages * 100, 2); ;

                transaction = repository.BeginTransaction();

                repository.Insert(dateRequest);

                repository.Inserts(servicePeriodOffices);

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
