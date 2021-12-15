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
    public class CountActiveOperatorsDay : IHostedService, IDisposable
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private Timer _timer;

        public CountActiveOperatorsDay(IServiceScopeFactory scopeFactory) => _scopeFactory = scopeFactory;
        
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
            try
            {
                
                using var scope = _scopeFactory.CreateScope();
                var repository = scope.ServiceProvider.GetRequiredService<IRepository>();

                var dateStart = DateTime.Now;
                var activeOperator = repository.SprEmployeesAuthorizationLogs
                    .Count(w => w.LogInDate.Date==DateTime.Now.Date&&
                                w.SprEmployees.SprEmployeesMfcJoins.Any(a=> a.DateStart < DateTime.Now && (a.DateStop == null || a.DateStop > DateTime.Now)&& a.SprEmployeesRoleJoins
                                    .Any(aa=>aa.SprEmployeesRoleId==3&&aa.DateStart<DateTime.Now&&(aa.DateStop==null||aa.DateStop>DateTime.Now))));

                repository.Insert(new ApiManagerPanelActiveOperator
                {
                    DateQuery = dateStart,
                    CountActiveOperator = activeOperator,
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
