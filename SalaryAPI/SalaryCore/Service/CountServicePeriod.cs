using DataLayer.Abstract;
using DataLayer.Entities.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SalaryCore.Service
{
    public class CountServicePeriod : IHostedService, IDisposable
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private Timer _timer;

        public CountServicePeriod(IServiceScopeFactory scopeFactory) => _scopeFactory = scopeFactory;
        
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
            try
            {
                using var scope = _scopeFactory.CreateScope();
                var repository = scope.ServiceProvider.GetRequiredService<IRepository>();

                var servicePeriod =
                    repository.ApiManagerPanelServicePeriods.FirstOrDefault();

                if (servicePeriod is not null) return;
                var servicesReceived = repository.GetApiReceivedServices.FirstOrDefault();
                var servicesExecuted = repository.GetApiExecutedServices.FirstOrDefault();
                var expiredServices = repository.GetApiExpiredServices.FirstOrDefault();
                var expiredStages = repository.GetApiExpiredStages.FirstOrDefault();

                if (servicesReceived is not null && servicesExecuted is not null && expiredServices is not null && expiredStages is not null)
                {
                    repository.Insert(new ApiManagerPanelServicePeriod
                    {
                        CountExecutedWeek = servicesExecuted.CountWeek,
                        CountExecutedMonth = servicesExecuted.CountMonth,
                        CountExecutedQuarter = servicesExecuted.CountQuarter,
                        CountExecutedYear = servicesExecuted.CountYear,
                        CountReceivedWeek = servicesReceived.CountWeek,
                        CountReceivedMonth = servicesReceived.CountMonth,
                        CountReceivedQuarter = servicesReceived.CountQuarter,
                        CountReceivedYear = servicesReceived.CountYear,
                        CountExpired = expiredServices.CountExpired,
                        PercentExpired = expiredServices.Percent,
                        CountExpiredStage = expiredStages.CountExpired,
                        PercentExpiredStage = expiredStages.Percent,
                        //DateQuery = DateTime.Now
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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
