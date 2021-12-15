using DataLayer.Abstract;
using DataLayer.Entities.Functions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalaryCore.Contracts.AdminPanel;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCore.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    public class AdminPanelController : ControllerBase
    {
        private readonly IRepository _repository;

        /// <summary>
        /// Справочник "Админ"
        /// </summary>
        public AdminPanelController(IRepository repository) => _repository = repository;
        /// <summary>
        /// Запрос данных очереди
        /// </summary>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/queue")]
        [SwaggerOperation(Summary = "Запрос данных очереди",
                Description = "DateQueryId = Индетификатор записи" +
                              "DateQueryAdd = Дата выполнения запроса" +
                              "workWindows = Окон ведущие прием " +
                              "DefferenceWorkWindows = разница между предыдущим значением" +
                              "IsDefferenceWorkWindows = Динамика от предыдущего значения true-положительно, false-отрицательно" +
                              "DefferencePercentWorkWindows = процентное соотношентие от предыдущего значения" +
                              "ActiveOperators = Активные операторы" +
                              "DefferenceActiveOperators = разница между предыдущим значением" +
                              "IsDefferenceActiveOperators = Динамика от предыдущего значения true-положительно, false-отрицательно" +
                              "DefferencePercentActiveOperators = процентное соотношентие от предыдущего значения" +
                              "longTimeQueue = Количество ожидающих талонов: Больше 15 мин " +
                              "DefferenceLongTimeQueue = разница между предыдущим значением" +
                              "IsDefferenceLongTime = Динамика от предыдущего значения true-положительно, false-отрицательно" +
                              "DefferencePercentLongTime = процентное соотношентие от предыдущего значения" + 
                              "countOfficesLong = количество офисов" +
                              "LittleTimeQueue = Количество ожидающих талонов: Менее 15 мин " +
                              "DefferenceLittleTimeQueue = разница между предыдущим значением" +
                              "IsDefferenceLittleTime = Динамика от предыдущего значения true-положительно, false-отрицательно" +
                              "DefferencePercentLittleTime = процентное соотношентие от предыдущего значения" +
                              "countOfficesLittle = количество офисов" +
                              "averageTimeQueue = Среднее время ожидания " +
                              "DefferenceAverageTime = разница между предыдущим значением" +
                              "IsDefferenceAverageTime = Динамика от предыдущего значения true-положительно, false-отрицательно" +
                              "DefferencePercentAverageTime = процентное соотношентие от предыдущего значения" +
                              "maximumTimeQueue = Время ожидания в очереди талоны max значением в в минутах" +
                              "DefferenceMaximumTime = разница между предыдущим значением" +
                              "IsDefferenceMaximumTime = Динамика от предыдущего значения true-положительно, false-отрицательно" +
                              "DefferencePercentMaximumTime = процентное соотношентие от предыдущего значения" +
                              "MinimumTimeQueue = Время ожидания в очереди талоны с min значением в в минутах " +
                              "DefferenceMinimumTime = разница между предыдущим значением" +
                              "IsDefferenceMinimumTime = Динамика от предыдущего значения true-положительно, false-отрицательно" +
                              "DefferencePercentMinimumTime = процентное соотношентие от предыдущего значения")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<AverageDataQueueResponse>> GetQueue()
        {
            var data = await _repository.ApiManagerPanelQueues
                .AsNoTracking()
                .OrderByDescending(o => o.DateAnswer)
                .Select(s => new {
                    s.Id,
                    s.DateAnswer,
                    countWorkWindows = s.CountWorkWindows.Value,
                    countCustomerLong = s.CountCustomerLong.Value,
                    countCustomerLongOffices = s.ApiManagerPanelQueueInfos.Where(w=>w.CountCustomerLong.HasValue).Count(c=>c.CountCustomerLong.Value>0),
                    countCustomerLittle = s.CountCustomerLittle.Value,
                    countCustomerLittleOffices = s.ApiManagerPanelQueueInfos.Where(w => w.CountCustomerLittle.HasValue).Count(c => c.CountCustomerLittle.Value > 0),
                    countActiveOperator = s.CountActiveOperator.Value,
                    averageWaitingTime = s.AverageWaitingTime.Value,
                    minWaitTime = s.MinWaitTime.HasValue ? s.MinWaitTime.Value : TimeSpan.Zero,
                    maxWaitTime = s.MaxWaitTime.HasValue ? s.MaxWaitTime.Value : TimeSpan.Zero
                })
                .Take(2)
                .ToListAsync();

            var current = data.First();
            var prev = data.Last(); ;

            var PercentWorkWindows = prev.countWorkWindows!=0 ?  Math.Round((double)current.countWorkWindows / prev.countWorkWindows * 100, 2) : 100.00;
            var PercentLongTime = prev.countCustomerLong != 0 ? Math.Round((double)current.countCustomerLong / prev.countCustomerLong * 100, 2) : 100.00;
            var PercentLittleTime = prev.countCustomerLittle != 0 ? Math.Round((double)current.countCustomerLittle / prev.countCustomerLittle * 100, 2) : 100.00;
            var PercentActiveOperator = prev.countActiveOperator != 0 ? Math.Round((double)current.countActiveOperator / prev.countActiveOperator * 100, 2) : 100.00;
            var PercentAverageTime = prev.averageWaitingTime != TimeSpan.Zero ? Math.Round(current.averageWaitingTime.TotalSeconds / prev.averageWaitingTime.TotalSeconds * 100, 2) : 100.00;
            var PercentMaximumTime = Math.Round(current.maxWaitTime.TotalSeconds / prev.maxWaitTime.TotalSeconds * 100, 2);
            var PercentMinimumTime = Math.Round(current.minWaitTime.TotalSeconds / prev.minWaitTime.TotalSeconds * 100, 2);

            return new AverageDataQueueResponse(
                current.Id, current.DateAnswer,
                current.countWorkWindows, current.countWorkWindows - prev.countWorkWindows, current.countWorkWindows > prev.countWorkWindows, PercentWorkWindows,
                current.countActiveOperator, current.countActiveOperator - prev.countActiveOperator, current.countActiveOperator > prev.countActiveOperator, PercentActiveOperator,
                current.countCustomerLong, current.countCustomerLong - prev.countCustomerLong, current.countCustomerLong < prev.countCustomerLong, PercentLongTime, current.countCustomerLongOffices,
                current.countCustomerLittle, current.countCustomerLittle - prev.countCustomerLittle, current.countCustomerLittle > prev.countCustomerLittle, PercentLittleTime, current.countCustomerLittleOffices,
                DateTime.Today.Add(current.averageWaitingTime).ToLongTimeString(), DateTime.Today.Add(current.averageWaitingTime - prev.averageWaitingTime).ToLongTimeString(), current.averageWaitingTime < prev.averageWaitingTime, PercentAverageTime,
                DateTime.Today.Add(current.maxWaitTime).ToLongTimeString(), DateTime.Today.Add(current.maxWaitTime - prev.maxWaitTime).ToLongTimeString(), current.maxWaitTime < prev.maxWaitTime, PercentMaximumTime, 
                DateTime.Today.Add(current.minWaitTime).ToLongTimeString(), DateTime.Today.Add(current.minWaitTime - prev.minWaitTime).ToLongTimeString(), current.minWaitTime < prev.minWaitTime, PercentMinimumTime);

        }

        /// <summary>
        /// Запрос информации о МФЦ
        /// </summary>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/staticData")]
        [SwaggerOperation(Summary = "Запрос информации о МФЦ",
            Description = "totalMfc = Всего МФЦ " +
                         "totalTOSP = Всего ТОСП  " +
                         "populationCoverage = Охват населения " +
                         "MonitoringQualities = Уровень удовлетворенности  " +
                         "TotalWindowsMfc = Всего окон МФЦ   " +
                         "TotalWindowsWork = Всего окон ТОСП " +
                         "AverageSalaryDirector = Средняя зп директора" +
                         "AverageSalarySpecialist = Средняя зп специалиста" +
                         "AverageSalary = Средняя зп оператора")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<StaticDataMfcResponse> GetStaticDataMfc()
        {
            return new StaticDataMfcResponse(58, 440, 40, 30, 20, "98%", "98.6%", 600, 400);
        }

        /// <summary>
        /// Количество принятых и исполненных услуг на текущий момент
        /// </summary>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/servicesDay")]
        [SwaggerOperation(Summary = "Количество принятых и исполненных услуг на текущий момент ",
            Description = "CountDayReceived = Количество принятых услуг, CountDayExecuted = Количество исполненных услуг")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ApiServicesDay>> GetServicesDay()
        {
            return await _repository.GetApiServicesDays.AsNoTracking().FirstOrDefaultAsync();
        }
        /// <summary>
        /// Количество принятых и исполненных услуг на текущий момент (разбивка по неделе/месяц/квартал/год)
        /// </summary>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/servicesPeriod")]
        [SwaggerOperation(Summary = "Количество принятых и исполненных услуг на текущий момент (разбивка по неделе/месяц/квартал/год)",
              Description = "DateQueryId = Индетификатор записи" +
                            "DateQueryAdd = Дата выполнения запроса" +
                            "CountReceivedMonth = Количество принятых услуг за месяц" +
                            "CountExecutedMonth = Количество исполненных услуг за месяц" +
                            "ExecutionService = Количество услуг на исполненния" +
                            "DefferenceExecutionService = разница между предыдущим значением" +
                            "IsDefferenceExecution = Динамика от предыдущего значения true-положительно, false-отрицательно" +
                            "DefferencePercentExecutions = процентное соотношентие от предыдущего значения" +
                            "CountExpired = Количество просроченных услуг" +
                            "PercentExpired = процентное соотношентие от всех услуг" +
                            "DefferenceExpired = разница между предыдущим значением" +
                            "IsDefferenceExpired = Динамика от предыдущего значения true-положительно, false-отрицательно" +
                            "DefferencePercentExpired = процентное соотношентие от предыдущего значения" +
                            "CountExpiredStage = Количество просроченных этапов" +
                            "PercentExpiredStage = процентное соотношентие от всех этапов" +
                            "DefferenceExpiredStage = разница между предыдущим значением" +
                            "IsDefferenceExpiredStage = Динамика от предыдущего значения true-положительно, false-отрицательно" +
                            "DefferencePercentExpiredStage = процентное соотношентие от предыдущего значения")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetServicesPeriod>> GetServicesPeriod()
        {
            var data = await _repository.ApiManagerPanelServiceDates
                .AsNoTracking()
                .OrderByDescending(o => o.DateAnswer)
                .Select(s => new
                {   s.Id,
                    s.DateAnswer,
                    CountReceivedMonth = s.ReceivedCountMonth,
                    CountExecutedMonth = s.ExecutedCountMonth,
                    CountExpired = s.CountExpiredService,
                    PercentExpired = s.PercentExpiredService,
                    CountExpiredStage = s.CountExpiredStages,
                    PercentExpiredStage = s.PercentExpiredStages,
                    s.CountExecutionService,
                })
                .Take(2)
                .ToListAsync();

            var current = data.First();
            var prev = data.Last();

            return new GetServicesPeriod(current.Id, current.DateAnswer,  current.CountReceivedMonth,current.CountExecutedMonth, 
                    current.CountExecutionService, current.CountExecutionService >= prev.CountExecutionService, current.CountExecutionService - prev.CountExecutionService, Math.Round((double)current.CountExecutionService / (double)prev.CountExecutionService * 100, 2),
                    current.CountExpired, Math.Round((double)current.PercentExpired, 2), current.CountExpired <= prev.CountExpired, current.CountExpired - prev.CountExpired, Math.Round((double)current.CountExpired / (double)prev.CountExpired * 100, 2),
                    current.CountExpiredStage, Math.Round((double)current.PercentExpiredStage, 2), current.CountExpiredStage <= prev.CountExpiredStage, current.CountExpiredStage - prev.CountExpiredStage, Math.Round((double)current.CountExpiredStage / (double)current.CountExpiredStage * 100, 2));

        }

        /// <summary>
        /// Исполнение гос. задания с начала текущего года (количество и % от установленного показателя)
        /// </summary>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/stateTaskServices")]
        [SwaggerOperation(Summary = "Процент исполнения госзадания в формате: количество (цифра)/процент от норматива")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetServicesPercentStateTask>> GetStateTaskServices()
        {
            return await _repository.ApiManagerPanelStateTasks.AsNoTracking()
                 .Where(w => w.DateQuery.Date == DateTime.Now.Date)
                 .Select(s => new {s.CountServiceFact.Value ,s.Percent, s.DateQuery })
                 .GroupBy(g => g.DateQuery)
                 .Select(s => new GetServicesPercentStateTask(s.Key, s.Sum(x=>x.Value),s.Average(a => a.Percent)))
                 .FirstOrDefaultAsync();
        }
       /* /// <summary>
        /// Количество активных операторов
        /// </summary>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/activeOperators")]
        [SwaggerOperation(Summary = "Количество активных операторов")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<object>> GetActiveOperators()
        {
            var data = await _repository.ApiManagerPanelActiveOperators
                .AsNoTracking()
                .OrderByDescending(o => o.DateQuery)
                .Select(s => new
                {
                    s.DateQuery,
                    s.CountActiveOperator,
                })
                .Take(2)
                .ToListAsync();


            var current = data.First();
            var prev = data.Last();

            return new {current.CountActiveOperator, 
                        IsDefferenceActiveOperator = current.CountActiveOperator>=prev.CountActiveOperator, 
                        DefferenceActiveOperator = current.CountActiveOperator - prev.CountActiveOperator };
        }*/

        /// <summary>
        /// Количество активных операторов
        /// </summary>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/offices/averageTime")]
        [SwaggerOperation(Summary = "Получение списка офисов с среднем временим ожидания")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<object>> GetOfficesAverageTime([FromQuery] Guid dateQueryId)
        {
            return await _repository.ApiManagerPanelQueueInfos
                .AsNoTracking()
                .Where(w => w.ApiManagerPanelQueueId == dateQueryId)
                .Select(s => new
                {
                    s.SprEmployeesMfc.MfcName,
                    AverageWaitingTime = s.AverageWaitingTime.HasValue ? DateTime.Today.Add(s.AverageWaitingTime.Value).ToLongTimeString() : "Не определено",
                })
                .OrderByDescending(o => o.MfcName)
                .ToListAsync();
        }

        /// <summary>
        /// Получение списка офисов с рабочим окнами и активными операторами
        /// </summary>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/offices/workWindows")]
        [SwaggerOperation(Summary = "Получение списка офисов с рабочим окнами и активными операторами")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<object>> GetOfficesWorkWindows([FromQuery] Guid dateQueryId)
        {
            return await _repository.ApiManagerPanelQueueInfos
                .AsNoTracking()
                .Where(w=>w.ApiManagerPanelQueueId==dateQueryId)
                .Select(s => new
                {
                   s.SprEmployeesMfc.MfcName,
                   s.CountWorkWindows,
                   s.CountActiveOperator
                })
                .OrderByDescending(o=>o.MfcName)
                .ToListAsync();
        }
        /// <summary>
        /// Получение списка офисов с талонами ожидания
        /// </summary>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/offices/couponsLine")]
        [SwaggerOperation(Summary = "Получение списка офисов с талонами ожидания")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<object>> GetOfficesCouponsLine([FromQuery] Guid dateQueryId)
        {
            return await _repository.ApiManagerPanelQueueInfos
                .AsNoTracking()
                .Where(w => w.ApiManagerPanelQueueId == dateQueryId)
                .Select(s => new
                {
                    s.SprEmployeesMfc.MfcName,
                    s.CountCustomerLong,
                    s.CountCustomerLittle
                })
                .OrderByDescending(o => o.MfcName)
                .ToListAsync();
        }

        /// <summary>
        /// Получение списка офисов с мин и макс временим ожидания
        /// </summary>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/offices/waitingTime")]
        [SwaggerOperation(Summary = "Получение списка офисов с мин и макс временим ожидания")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<object>> GetOfficesWaitingTime([FromQuery] Guid dateQueryId)
        {
            return await _repository.ApiManagerPanelQueueInfos
                .AsNoTracking()
                .Where(w => w.ApiManagerPanelQueueId == dateQueryId)
                .Select(s => new
                {
                    s.SprEmployeesMfc.MfcName,
                    MaxWaitTime = s.MaxWaitTime.HasValue ? DateTime.Today.Add(s.MaxWaitTime.Value).ToLongTimeString() : "Не определено",
                    MinWaitTime = s.MinWaitTime.HasValue ? DateTime.Today.Add(s.MinWaitTime.Value).ToLongTimeString() : "Не определено",
                })
                .OrderByDescending(o => o.MfcName)
                .ToListAsync();
        }


        /// <summary>
        /// Получение списка офисов с принятами услугами за месяц
        /// </summary>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/offices/services/receivedMonth")]
        [SwaggerOperation(Summary = "Получение списка офисов с принятами услугами за месяц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<object>> GetServicesReceivedMonth([FromQuery] Guid dateQueryId)
        {
           return await _repository.ApiManagerPanelServicePeriods
                .AsNoTracking()
                .Where(w=>w.ApiManagerPanelServiceDateId == dateQueryId)
                .Select(s => new
                {
                    s.SprEmployeesMfc.MfcName,
                    s.CountReceivedMonth
                })
                .OrderByDescending(o => o.MfcName)
                .ToListAsync();
        }

        /// <summary>
        /// Получение списка офисов с исполненными услугами за месяц
        /// </summary>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/offices/services/executedMonth")]
        [SwaggerOperation(Summary = "Получение списка офисов с исполненными услугами за месяц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<object>> GetServicesExecutedMonth([FromQuery] Guid dateQueryId)
        {
            return await _repository.ApiManagerPanelServicePeriods
                 .AsNoTracking()
                 .Where(w => w.ApiManagerPanelServiceDateId == dateQueryId)
                 .Select(s => new
                 {
                     s.SprEmployeesMfc.MfcName,
                     s.CountExecutedMonth
                 })
                 .OrderByDescending(o => o.MfcName)
                 .ToListAsync();
        }

        /// <summary>
        /// Получение списка офисов с услугами на исполненния
        /// </summary>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/offices/services/executions")]
        [SwaggerOperation(Summary = "Получение списка офисов с услугами на исполненния")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<object>> GetServicesExecutions([FromQuery] Guid dateQueryId)
        {
            return await _repository.ApiManagerPanelServicePeriods
                 .AsNoTracking()
                 .Where(w => w.ApiManagerPanelServiceDateId == dateQueryId)
                 .Select(s => new
                 {
                     s.SprEmployeesMfc.MfcName,
                     s.CountExecutionService
                 })
                 .OrderByDescending(o => o.MfcName)
                 .ToListAsync();
        }

        /// <summary>
        /// Получение списка офисов с просроченными услугами
        /// </summary>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/offices/services/expired")]
        [SwaggerOperation(Summary = "Получение списка офисов с просроченными услугами")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<object>> GetServicesExpired([FromQuery] Guid dateQueryId)
        {
            return await _repository.ApiManagerPanelServicePeriods
                 .AsNoTracking()
                 .Where(w => w.ApiManagerPanelServiceDateId == dateQueryId)
                 .Select(s => new
                 {
                     s.SprEmployeesMfc.MfcName,
                     s.CountExpired
                 })
                 .OrderByDescending(o => o.MfcName)
                 .ToListAsync();
        }

        /// <summary>
        /// Получение списка офисов с просроченными этапами
        /// </summary>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/offices/services/stageExpired")]
        [SwaggerOperation(Summary = "Получение списка офисов с просроченными этапами")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<object>> GetServicesStageExpired([FromQuery] Guid dateQueryId)
        {
            return await _repository.ApiManagerPanelServicePeriods
                 .AsNoTracking()
                 .Where(w => w.ApiManagerPanelServiceDateId == dateQueryId)
                 .Select(s => new
                 {
                     s.SprEmployeesMfc.MfcName,
                     s.CountExpiredStage
                 })
                 .OrderByDescending(o => o.MfcName)
                 .ToListAsync();
        }
    }
}
