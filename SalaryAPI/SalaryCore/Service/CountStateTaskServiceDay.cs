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
    public class CountStateTaskServiceDay : IHostedService, IDisposable
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private Timer _timer;

        public CountStateTaskServiceDay(IServiceScopeFactory scopeFactory) => _scopeFactory = scopeFactory;
        
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

                var servicePeriod = repository.ApiManagerPanelStateTasks.FirstOrDefault(f => f.DateQuery.Date == DateTime.Now.Date);

                if (servicePeriod is not null) return;

                var servicesStateTask = repository.GetApiStateTaskServices.ToList();

                var dateQuery = DateTime.Now;

                servicesStateTask.ForEach(f =>
                {
                    if(f.Percent is null) return;

                    repository.Insert(new ApiManagerPanelStateTask
                    {
                        DateQuery = dateQuery,
                        SprEmployeesMfcId = f.MfcId,
                        Percent = (decimal)f.Percent,
                        CountServiceFact = f.CountFact
                    });
                });
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
