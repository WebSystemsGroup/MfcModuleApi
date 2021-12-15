using DataLayer.Abstract;
using DataLayer.Entities.Functions;
using DataLayer.Entities.Models;
using DataLayer.Extensions;
using DataLayer.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SalaryCore.Contracts.Employee;
using SalaryCore.Extensions;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace SalaryCore.Controllers
{
    /// <summary>
    /// Справочник "Сотрудники"
    /// </summary>
    [Route("api/")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    public class EmployeesController : ControllerBase
    {
        private readonly IRepository _repository;

        /// <summary>
        /// Справочник "Сотрудники"
        /// </summary>
        public EmployeesController(IRepository repository) => _repository = repository;
      
        #region |-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-[ Запросы офиса ]-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|

        /// <summary>
        /// Запрос реестра МФЦ
        /// </summary>
        /// <returns>Реестр офисов</returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/officesAll")]
        [SwaggerOperation(Summary = "Запрос реестра МФЦ")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetOfficesResponseData>>> GetOffices()
        {
            return await _repository.SprEmployeesMfcs
                    .AsNoTracking()
                    .Where(w => (bool)!w.StructuralSubdivision)
                    .Select(s => new GetOfficesResponseData(s.Id, s.MfcNameSmall))
                    .ToListAsync();
        }

        /// <summary>
        /// Запрос реестра сотрудников МФЦ
        /// </summary>
        /// <param name="mfcId"></param>
        /// <returns>Реестр сотрудников</returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/employees")]
        [SwaggerOperation(Summary = "Запрос реестра сотрудников МФЦ")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetEmployeeResponseData>>> GetEmployees([FromQuery] Guid mfcId)
        {
            if (!mfcId.IsValidIdentifier())
                return BadRequest(ErrorDescription.InvalidInputParameters);

            return await _repository.SprEmployeesMfcJoins
                .AsNoTracking()
                .Where(w => w.SprEmployeesMfcId == mfcId)
                .Select(s => new GetEmployeeResponseData(s.SprEmployeesId, s.SprEmployees.EmployeeFio, s.SprEmployeesJobPos.JobPosName))
                .ToListAsync();
        }
        /// <summary>
        /// Запрос реестра сотрудников МФЦ
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>Реестр сотрудников</returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/salaryMfc")]
        [SwaggerOperation(Summary = "Общие данные по филиалу за месяц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetSalaryMfcResponseData>>> GetSalaryMfc([FromQuery] GetSalaryMfcRequestData requestData)
        {
            var validationResult = await requestData.ValidateAsync();
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.ErrorMessage());

            var data = await _repository.ArchivePremiums
                .AsNoTracking()
                .Where(w => w.SprEmployeesMfcId == requestData.MfcId && w.PeriodMonth == requestData.Month && w.PeriodYear == requestData.Year)
                .Select(s => new
                {
                    s.SprEmployeesId,
                    s.SprEmployees.EmployeeFio,
                    s.SprEmployeesJobPosId,
                    s.EmployeesJobPosName,
                    s.PeriodCountDay,
                    s.Type,
                    s.EmployeesSalary,
                    s.EmployeesStake,
                    s.FineSum,
                    s.StepPremium,
                    s.StepPremiumOther,
                    CountDayWork = s.EmployeesSalary > 0 ? 1 : 0
                })
                .ToListAsync();


              return data.GroupBy(g => new { g.SprEmployeesId, g.EmployeeFio, g.SprEmployeesJobPosId, g.EmployeesJobPosName, g.PeriodCountDay, g.Type })
                        .Select(s => new
                        {
                            obj = s.Select(ss => new { ss.SprEmployeesId, ss.EmployeeFio, ss.SprEmployeesJobPosId, ss.EmployeesJobPosName, ss.PeriodCountDay, ss.Type }).First(),
                            stake = s.Max(m => m.EmployeesStake),
                            salary = s.Sum(sum => sum.EmployeesSalary),
                            fine = s.Sum(sum => sum.FineSum),
                            stepPremium = s.Sum(sum => sum.StepPremium),
                            stepPremiumOther = s.Sum(sum => sum.StepPremiumOther),
                            countDayWork = s.Sum(sum => sum.CountDayWork)
                        })
                    .Select(s => new GetSalaryMfcResponseData(s.obj.SprEmployeesId, s.obj.EmployeeFio, s.obj.SprEmployeesJobPosId, s.obj.EmployeesJobPosName,
                                                                        (int)s.obj.PeriodCountDay, (int)s.obj.Type, Math.Round(s.salary,2), Math.Round(s.stake, 2), Math.Round(s.fine, 2), Math.Round(s.stepPremium, 2), Math.Round(s.stepPremiumOther, 2), s.countDayWork))
                    .ToList();
        }
        /// <summary>
        /// Запрос реестра сотрудников МФЦ
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>Реестр сотрудников</returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/salaryEmployee")]
        [SwaggerOperation(Summary = "Детализация ЗП на сотрудникаЦ")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetSalaryEmployeeResponseData>>> GetSalaryEmployee([FromQuery] GetSalaryEmployeeRequestData requestData)
        {
            var validationResult = await requestData.ValidateAsync();
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.ErrorMessage());

            return await _repository.ArchivePremiums
                .AsNoTracking()
                .Where(w => w.SprEmployeesMfcId == requestData.MfcId && w.SprEmployeesId == requestData.EmployeeId && w.PeriodMonth == requestData.Month && w.PeriodYear == requestData.Year)
                .Select(s => new GetSalaryEmployeeResponseData(s.SprEmployeesJobPosId, s.EmployeesJobPosName, s.PeriodDate,
                    (int)s.Type, s.EmployeesSalary, s.EmployeesStake, s.FineSum, s.StepPremium, s.StepPremiumOther, s.EmployeesPremiumTotal))
                .ToListAsync();
        }
        /// <summary>
        /// Реестр межевых услуг
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/surveyingServices")]
        [SwaggerOperation(Summary = "Реестр межевых услуг")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<ReportSalarySurveyingReestrServices>>> GetSurveyingServices([FromQuery] GetSurveyingServicesRequestData requestData)
        {
            var validationResult = await requestData.ValidateAsync();
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.ErrorMessage());

            return await _repository.GetReportSalarySurveyingReestrServicess(requestData.MfcId, requestData.EmployeeId, (int)requestData.Type, requestData.DateStart, requestData.DateStop)
                .ToListAsync();
        }
        /// <summary>
        /// Реестр коммерческих услуг
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/commercialServices")]
        [SwaggerOperation(Summary = "Реестр коммерческих услуг")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<ReportSalaryComercialReestrServices>>> GetCommercialServices([FromQuery] GetCommercialServicesRequestData requestData)
        {
            var validationResult = await requestData.ValidateAsync();
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.ErrorMessage());

            return await _repository.GetReportSalaryComercialReestrServices(requestData.MfcId, requestData.EmployeeId, requestData.DateStart, requestData.DateStop)
                .ToListAsync();
        }
        /// <summary>
        /// Отчет по межевым услугам
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/report/surveyingServices")]
        [SwaggerOperation(Summary = "Отчет по межевым услугам")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<ReportSalarySurveying>>> GetReportSalarySurveying([FromQuery] GetReportSalarySurveyingRequestData requestData)
        {
            var validationResult = await requestData.ValidateAsync();
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.ErrorMessage());

            return await _repository.GetReportSalarySurveying(requestData.MfcId, requestData.DateStart, requestData.DateStop)
                .ToListAsync();
        }
        /// <summary>
        /// Отчет по межевым услугам
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/report/commercialServices")]
        [SwaggerOperation(Summary = "Отчет по коммерческим  услугам")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<ReportSalaryCommercial>>> GetReportSalaryCommercial([FromQuery] GetReportSalaryCommercialRequestData requestData)
        {
            var validationResult = await requestData.ValidateAsync();
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.ErrorMessage());

            return await _repository.GetReportSalaryCommercial(requestData.MfcId, requestData.EmployeeId, requestData.DateStart, requestData.DateStop)
                .ToListAsync();
        }
        /// <summary>
        /// Запрос зарплаты одного сотрудника
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/salaryOne")]
        [SwaggerOperation(Summary = "Расчет ЗП на сотрудника")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<SalaryCalcOneEmployees>>> GetSalaryCalcOneEmployees([FromQuery] GetSalaryCalcOneEmployeesRequestData requestData)
        {
            var validationResult = await requestData.ValidateAsync();
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.ErrorMessage());

            return await _repository.GetSalaryCalcOneEmployees(requestData.EmployeeId, requestData.DateStart, requestData.DateStop, requestData.Type, requestData.IsSave)
                .ToListAsync();
        }
        #endregion

        #region |-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-[ Запросы справочника сотрудника  ]-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|
        /// <summary>
        /// Запрос Реестра должностей
        /// </summary>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/jobPosition")]
        [SwaggerOperation(Summary = "Запрос Реестра должностей")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetJobPositionResponseData>>> GetJobPosition()
        {
            return await _repository.SprEmployeesJobPos
                    .Select(s => new GetJobPositionResponseData(s.Id, s.JobPosName))
                    .ToListAsync();
        }
        /// <summary>
        /// Запрос Реестра Статусов
        /// </summary>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/status")]
        [SwaggerOperation(Summary = "Запрос Реестра Статусов")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetStatusResponseData>>> GetStatus()
        {
            return await _repository.SprEmployeesStatus
                    .Select(s => new GetStatusResponseData(s.Id, s.StatusName))
                    .ToListAsync();
        }
        /// <summary>
        /// Запрос Реестра Ролей
        /// </summary>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("/role")]
        [SwaggerOperation(Summary = "Запрос Реестра Ролей")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetRoleResponseData>>> GetRole()
        {
            return await _repository.SprEmployeesRoles
                    .Select(s => new GetRoleResponseData(s.Id, s.RoleName))
                    .ToListAsync();
        }
        #endregion

        #region |-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-[ Запросы офиса сотрудника  ]-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|

        /// <summary>
        /// Запрос списка мест работы сотрудника
        /// </summary>
        /// <param name="id">Индетификатор сотрудника</param>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("[controller]/offices")]
        [SwaggerOperation(Summary = "Запрос списка мест работы сотрудника")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetEmployeeOfficesResponseData>>> GetEmployeeOffices([FromQuery] Guid id)
        {
            if (!id.IsValidIdentifier()) return BadRequest(ErrorDescription.InvalidInputParameters);

            return await _repository.SprEmployeesMfcJoins
                .Select(s => new GetEmployeeOfficesResponseData(s.Id, s.EmployeesMfcName, s.SprEmployeesSalaries.First(f => f.DateStop == null).EmployeesJobPosName, s.DateStart, s.DateStop, s.EmployeesFioAdd))
                .OrderByDescending(o => o.DateStart)
                .ToListAsync();
        }
        /// <summary>
        /// Запрос добавления нового МФЦ сотруднику
        /// </summary>
        /// <param name="requestData">Данные запроса</param>
        /// <returns></returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpPost("[controller]/offices")]
        [SwaggerOperation(Summary = "Запрос добавления нового МФЦ сотруднику")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> AddEmployeeOffices([FromForm] AddEmployeeMfcRequestData requestData)
        {
            IDbContextTransaction transaction = null;
            try
            {
                var validationResult = await requestData.ValidateAsync();
                if (!validationResult.IsValid)
                    return BadRequest(validationResult.Errors.ErrorMessage());

                var auth = await _repository.AuthenticatedUserInfo(HttpContext.User.GetUserId());

                var mfc = new SprEmployeesMfcJoin
                {
                    SprEmployeesId = requestData.EmployeeId,
                    SprEmployeesMfcId = requestData.MfcId,
                    DateStart = requestData.DateStart,
                    DateStop = requestData.DateStop,
                    SetEmployeesFio = auth.Fio
                };

                transaction = _repository.BeginTransaction();

                _repository.Insert(mfc);

                _repository.Insert(new SprEmployeesSalary
                {
                    SprEmployeesMfcJoinId = mfc.Id,
                    DateStart = requestData.DateStart,
                    EmployeesSalary = requestData.Salary,
                    SprEmployeesJobPosId = requestData.JobPositionId,
                    EmployeesStake = requestData.Rate,
                    DateStop = requestData.DateStop,
                    EmployeesIntensity = requestData.Intensity,
                    CostMinute = requestData.CostMinute,
                    SetEmployeesFio = auth.Fio,
                    SetDate = DateTime.Now
                });

                _repository.Insert(new SprEmployeesRoleJoin
                {
                    SprEmployeesMfcJoinId = mfc.Id,
                    SprEmployeesRoleId = requestData.RoleId,
                    DateStart = requestData.DateStart,
                    SetEmployeesFio = auth.Fio,
                    SetDate = DateTime.Now
                });

                _repository.Insert(new SprEmployeesStatusJoin
                {
                    SprEmployeesMfcJoinId = mfc.Id,
                    SprEmployeesStatusId = requestData.StatusId,
                    DateStart = requestData.DateStart,
                    SetEmployeesFio = auth.Fio,
                    SetDate = DateTime.Now
                });

                _repository.Insert(new SprEmployeesExecution
                {
                    SprEmployeesMfcJoinId = mfc.Id,
                    EmployeesExecution = requestData.IsExecution,
                    DateStart = requestData.DateStart,
                    SetEmployeesFio = auth.Fio,
                    SetDate = DateTime.Now
                });

                if (transaction is not null) await transaction.CommitAsync();

                return Ok();
            }
            catch 
            {
                if (transaction is not null) await transaction.RollbackAsync();
                throw;
            }
        }
        #endregion

        #region |-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-[ Запросы должностей сотрудника  ]-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|
        [HttpGet("[controller]/jobPosition")]
        [SwaggerOperation(Summary = "Запрос получение должностей сотрудника по мфц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetEmployeeJobPositionsResponseData>>> GetEmployeeJobPosition([FromQuery] Guid id)
        {
            if (!id.IsValidIdentifier()) return BadRequest(ErrorDescription.InvalidInputParameters);

            return await _repository.SprEmployeesSalaries
                .Where(w=>w.SprEmployeesMfcJoinId==id&&w.RowDel==0)
                .Select(s => new GetEmployeeJobPositionsResponseData(s.Id, s.EmployeesJobPosName, s.DateStart, s.DateStop, s.EmployeesSalary, 
                    s.EmployeesStake, s.EmployeesIntensity, s.CostMinute, s.SetEmployeesFio, s.SetDate))
                .ToListAsync();
        }
        [HttpPut("[controller]/jobPosition")]
        [SwaggerOperation(Summary = "Запрос редактирования должности сотрудника по мфц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> EditEmployeeJobPosition([FromForm] EditEmployeeJobPositionsRequestData requestData)
        {
            var validationResult = await requestData.ValidateAsync();
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.ErrorMessage());

            var result = await _repository.FindAsync<SprEmployeesSalary>(requestData.Id);
            if (result is null) return NotFound("Запись не найдена");

            result.DateStart = requestData.DateStart;
            result.EmployeesSalary = requestData.Salary;
            result.SprEmployeesJobPosId = requestData.JobPositionId;
            result.EmployeesStake = requestData.Rate;
            result.DateStop = requestData.DateStop;
            result.EmployeesIntensity = requestData.Intensity;
            result.CostMinute = requestData.CostMinute;

            _repository.Update(result);

            return Ok();
        }

        [HttpDelete("[controller]/jobPosition/{id}")]
        [SwaggerOperation(Summary = "Запрос удаления должности сотрудника по мфц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteEmployeeJobPosition([FromRoute] Guid id)
        {
            IDbContextTransaction transaction = null;
            try
            {
                if (!id.IsValidIdentifier()) return BadRequest(ErrorDescription.InvalidInputParameters);

                var result = await _repository.FindAsync<SprEmployeesSalary>(id);
                if (result is null) return NotFound("Запись не найдена");

                var anyResult = await _repository.SprEmployeesSalaries
                    .Where(w => w.SprEmployeesMfcJoinId == result.SprEmployeesMfcJoinId&&w.RowDel==0)
                    .OrderByDescending(o => o.DateAdd)
                    .Take(2)
                    .ToListAsync();
                    
                if(anyResult is null or {Count:<2} || anyResult.First().Id !=id)
                    return BadRequest("Нельзя удалить данный статус т.к. он не последний.");

                var beforeLastAddStatus = anyResult.Last();

                transaction = _repository.BeginTransaction();

                result.RowDel = 1;
                _repository.Update(result);

                beforeLastAddStatus.DateStop = null;
                _repository.Update(beforeLastAddStatus);
                    
                await transaction.CommitAsync();

                return Ok();
            }
            catch 
            {
                if (transaction is not null) await transaction.RollbackAsync();
               throw;
            }
        }
        #endregion

        #region |-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-[ Запросы ролей сотрудника  ]-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|
        [HttpGet("[controller]/role")]
        [SwaggerOperation(Summary = "Запрос получение ролей сотрудника по мфц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetEmployeeRoleResponseData>>> GetEmployeeRole([FromQuery] Guid id)
        {
            if (!id.IsValidIdentifier()) return BadRequest(ErrorDescription.InvalidInputParameters);

            return await _repository.SprEmployeesRoleJoins
                .Where(w => w.SprEmployeesMfcJoinId == id && w.RowDel == 0)
                .Select(s => new GetEmployeeRoleResponseData(s.Id, s.SprEmployeesRole.RoleName, s.DateStart, s.DateStop, s.SetEmployeesFio, s.SetDate))
                .ToListAsync();
        }
        [HttpPost("[controller]/role")]
        [SwaggerOperation(Summary = "Запрос добавления роли сотрудника по мфц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> AddEmployeeRole([FromForm] AddEmployeeRoleRequestData requestData)
        {
            var validationResult = await requestData.ValidateAsync();
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.ErrorMessage());

            var auth = await _repository.AuthenticatedUserInfo(HttpContext.User.GetUserId());

            _repository.Insert(new SprEmployeesRoleJoin
            {
                SprEmployeesMfcJoinId = requestData.Id,
                SprEmployeesRoleId = requestData.RoleId,
                DateStart = requestData.DateStart,
                SetEmployeesFio = auth.Fio,
                SetDate = DateTime.Now
            });

            return Ok();
        }

        [HttpPut("[controller]/role")]
        [SwaggerOperation(Summary = "Запрос редактирования роли сотрудника по мфц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> EditEmployeeRole([FromForm] EditEmployeeRoleRequestData requestData)
        {
            var validationResult = await requestData.ValidateAsync();
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.ErrorMessage());

            var result = await _repository.FindAsync<SprEmployeesRoleJoin>(requestData.Id);
            if (result is null) return NotFound("Запись не найдена");

            result.SprEmployeesRoleId = requestData.RoleId;
            result.DateStart = requestData.DateStart;
            result.DateStop = requestData.DateStop;
            
            _repository.Update(result);

            return Ok();
        }
        [HttpDelete("[controller]/role/{id}")]
        [SwaggerOperation(Summary = "Запрос удаления роли сотрудника по мфц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteEmployeeRole([FromRoute] Guid id)
        {
            if (!id.IsValidIdentifier()) return BadRequest(ErrorDescription.InvalidInputParameters);

            var result = await _repository.FindAsync<SprEmployeesRoleJoin>(id);
            if (result is null) return NotFound("Запись не найдена");

            result.RowDel = 1;
            
            _repository.Update(result);

            return Ok();
        }
        #endregion

        #region |-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-[ Запросы статусов сотрудника  ]-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|
        [HttpGet("[controller]/status")]
        [SwaggerOperation(Summary = "Запрос получение статусов сотрудника по мфц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetEmployeeStatusResponseData>>> GetEmployeeStatus([FromQuery] Guid id)
        {
            if (!id.IsValidIdentifier()) return BadRequest(ErrorDescription.InvalidInputParameters);

            return await _repository.SprEmployeesStatusJoins
                .Where(w => w.SprEmployeesMfcJoinId == id && w.RowDel == 0)
                .Select(s => new GetEmployeeStatusResponseData(s.Id, s.StatusName, s.DateStart, s.DateStop, s.SetEmployeesFio, s.SetDate))
                .ToListAsync();
        }
        [HttpPost("[controller]/status")]
        [SwaggerOperation(Summary = "Запрос добавления статуса сотрудника по мфц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> AddEmployeeStatus([FromForm] AddEmployeeStatusRequestData requestData)
        {
            var validationResult = await requestData.ValidateAsync();
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.ErrorMessage());

            var auth = await _repository.AuthenticatedUserInfo(HttpContext.User.GetUserId());

            _repository.Insert(new SprEmployeesStatusJoin
            {
                SprEmployeesMfcJoinId = requestData.Id,
                SprEmployeesStatusId = requestData.StatusId,
                DateStart = requestData.DateStart,
                SetEmployeesFio = auth.Fio,
                SetDate = DateTime.Now
            });

            return Ok();
        }

        [HttpPut("[controller]/status")]
        [SwaggerOperation(Summary = "Запрос редактирования статуса сотрудника по мфц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> EditEmployeeStatus([FromForm] EditEmployeeStatusRequestData requestData)
        {
            var validationResult = await requestData.ValidateAsync();
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.ErrorMessage());

            var result = await _repository.FindAsync<SprEmployeesStatusJoin>(requestData.Id);
            if (result is null) return NotFound("Запись не найдена");

            result.SprEmployeesStatusId = requestData.StatusId;
            result.DateStart = requestData.DateStart;
            result.DateStop = requestData.DateStop;

            _repository.Update(result);

            return Ok();
        }
        [HttpDelete("[controller]/status/{id}")]
        [SwaggerOperation(Summary = "Запрос удаления статуса сотрудника по мфц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteEmployeeStatus([FromRoute] Guid id)
        {
            IDbContextTransaction transaction = null;
            try
            {
                if (!id.IsValidIdentifier()) return BadRequest(ErrorDescription.InvalidInputParameters);

                var result = await _repository.FindAsync<SprEmployeesStatusJoin>(id);
                if (result is null) return NotFound("Запись не найдена");

                var anyResult = await _repository.SprEmployeesStatusJoins
                    .Where(w => w.SprEmployeesMfcJoinId == result.SprEmployeesMfcJoinId&&w.RowDel==0)
                    .OrderByDescending(o => o.DateAdd)
                    .Take(2)
                    .ToListAsync();

                if (anyResult is null or { Count: < 2 } || anyResult.First().Id != id)
                    return BadRequest("Нельзя удалить данный статус т.к. он не последний.");

                var beforeLastAddStatus = anyResult.Last();

                transaction = _repository.BeginTransaction();

                result.RowDel = 1;
                _repository.Update(result);

                beforeLastAddStatus.DateStop = null;
                _repository.Update(beforeLastAddStatus);

                await transaction.CommitAsync();

                return Ok();
            }
            catch
            {
                if (transaction is not null) await transaction.RollbackAsync();
                throw;
            }
        }
        #endregion

        #region |-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-[ Запросы статусов исполнения сотрудника  ]-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|
        [HttpGet("[controller]/statusExecutions")]
        [SwaggerOperation(Summary = "Запрос получение статусов исполнения сотрудника по мфц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetEmployeeStatusExecutionsResponseData>>> GetEmployeeStatusExecutions([FromQuery] Guid id)
        {
            if (!id.IsValidIdentifier()) return BadRequest(ErrorDescription.InvalidInputParameters);

            return await _repository.SprEmployeesExecutions
                .Where(w => w.SprEmployeesMfcJoinId == id && w.RowDel == 0)
                .Select(s => new GetEmployeeStatusExecutionsResponseData(s.Id, s.EmployeesExecution, s.DateStart, s.DateStop, s.SetEmployeesFio, s.SetDate))
                .ToListAsync();
        }
        [HttpPost("[controller]/statusExecutions")]
        [SwaggerOperation(Summary = "Запрос добавления статуса исполнения сотрудника по мфц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> AddEmployeeStatusExecutions([FromForm] AddEmployeeStatusExecutionsRequestData requestData)
        {
            var validationResult = await requestData.ValidateAsync();
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.ErrorMessage());

            var auth = await _repository.AuthenticatedUserInfo(HttpContext.User.GetUserId());

            _repository.Insert(new SprEmployeesExecution
            {
                SprEmployeesMfcJoinId = requestData.Id,
                EmployeesExecution = requestData.IsExecution,
                DateStart = requestData.DateStart,
                SetEmployeesFio = auth.Fio,
                SetDate = DateTime.Now
            });

            return Ok();
        }

        [HttpPut("[controller]/statusExecutions")]
        [SwaggerOperation(Summary = "Запрос редактирования статуса исполнения сотрудника по мфц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> EditEmployeeStatusExecutions([FromForm] EditEmployeeStatusExecutionsRequestData requestData)
        {
            var validationResult = await requestData.ValidateAsync();
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.ErrorMessage());

            var result = await _repository.FindAsync<SprEmployeesExecution>(requestData.Id);
            if (result is null) return NotFound("Запись не найдена");

            result.EmployeesExecution = requestData.IsExecution;
            result.DateStart = requestData.DateStart;
            result.DateStop = requestData.DateStop;

            _repository.Update(result);

            return Ok();
        }
        [HttpDelete("[controller]/statusExecutions/{id}")]
        [SwaggerOperation(Summary = "Запрос удаления статуса исполнения сотрудника по мфц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteEmployeeStatusExecutions([FromRoute] Guid id)
        {
            IDbContextTransaction transaction = null;
            try
            {
                if (!id.IsValidIdentifier()) return BadRequest(ErrorDescription.InvalidInputParameters);

                var result = await _repository.FindAsync<SprEmployeesExecution>(id);
                if (result is null) return NotFound("Запись не найдена");

                var anyResult = await _repository.SprEmployeesExecutions
                    .Where(w => w.SprEmployeesMfcJoinId == result.SprEmployeesMfcJoinId && w.RowDel == 0)
                    .OrderByDescending(o => o.DateAdd)
                    .Take(2)
                    .ToListAsync();

                if (anyResult is null or { Count: < 2 } || anyResult.First().Id != id)
                    return BadRequest("Нельзя удалить данный статус т.к. он не последний.");

                var beforeLastAddStatus = anyResult.Last();

                transaction = _repository.BeginTransaction();

                result.RowDel = 1;
                _repository.Update(result);

                beforeLastAddStatus.DateStop = null;
                _repository.Update(beforeLastAddStatus);

                await transaction.CommitAsync();

                return Ok();
            }
            catch (Exception e)
            {
                if (transaction is not null) await transaction.RollbackAsync();
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
        #endregion

        #region |-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-[ Запросы совмещений сотрудника  ]-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|
        [HttpGet("[controller]/jobCombinations")]
        [SwaggerOperation(Summary = "Запрос получение совмещений сотрудника по мфц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetEmployeeJobPositionsCombinationResponseData>>> GetEmployeeJobCombination([FromQuery] Guid id)
        {
            if (!id.IsValidIdentifier()) return BadRequest(ErrorDescription.InvalidInputParameters);

            return await _repository.SprEmployeesJobPosCombinations
                .Where(w => w.SprEmployeesMfcJoinId == id && w.RowDel == 0)
                .Select(s => new GetEmployeeJobPositionsCombinationResponseData(s.Id, s.SprEmployeesJobPos.JobPosName, s.DateStart, s.DateStop, s.EmployeesSalary,
                    s.EmployeesStake, s.EmployeesIntensity,  s.SetEmployeesFio, s.SetDate))
                .ToListAsync();
        }
        [HttpPost("[controller]/jobCombinations")]
        [SwaggerOperation(Summary = "Запрос добавления совмещения сотрудника по мфц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> AddEmployeeJobCombination([FromForm] AddEmployeeJobPositionCombinationRequestData requestData)
        {
            var validationResult = await requestData.ValidateAsync();
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.ErrorMessage());

            var auth = await _repository.AuthenticatedUserInfo(HttpContext.User.GetUserId());

            _repository.Insert(new SprEmployeesJobPosCombination
            {
                SprEmployeesMfcJoinId = requestData.Id,
                DateStart = requestData.DateStart,
                EmployeesSalary = requestData.Salary,
                SprEmployeesJobPosId = requestData.JobPositionId,
                EmployeesStake = requestData.Rate,
                DateStop = requestData.DateStop,
                EmployeesIntensity = requestData.Intensity,
                SetEmployeesFio = auth.Fio,
                SetDate = DateTime.Now
            });

            return Ok();
        }

        [HttpDelete("[controller]/jobCombinations/{id}")]
        [SwaggerOperation(Summary = "Запрос удаления совмещения сотрудника по мфц")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteEmployeeJobCombination([FromRoute] Guid id)
        {
            if (!id.IsValidIdentifier()) return BadRequest(ErrorDescription.InvalidInputParameters);

            var result = await _repository.FindAsync<SprEmployeesJobPosCombination>(id);
            if (result is null) return NotFound("Запись не найдена");

            result.RowDel = 1;

            _repository.Update(result);

            return Ok();
        }
        #endregion

        #region |-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-[ Запросы получений зарплыты сотрудника за день  ]-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|
        [HttpGet("[controller]/sum/action")]
        [SwaggerOperation(Summary = "Запрос получение cуммы по действиям сотрудника за день")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetEmployeeSumActionResponseData>> GetEmployeeSumAction([FromQuery] GetEmployeeSumRequestData requestData)
        {
            var validationResult = await requestData.ValidateAsync();
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.ErrorMessage());

            return await _repository.ArchivePremiumStepSums
                .Where(w => w.ArchivePremium.SprEmployeesId == requestData.EmployeeId && w.ArchivePremium.PeriodDate == requestData.Date)
                .Select(s=>new GetEmployeeSumActionResponseData(
                    new SumAction(s.ProcessingPremium, s.ProcessingPremiumCount),
                    new SumAction(s.ServiceAdd, s.ServiceAddCount),
                    new SumAction(s.CustomerAdd, s.CustomerAddCount),
                    new SumAction(s.DocumentScan, s.DocumentScanCount),
                    new SumAction(s.ServiceConsultation, s.ServiceConsultationCount),
                    new SumAction(s.ServiceExecuted, s.ServiceExecutedCount),
                    new SumAction(s.CallCustomer, s.CallCustomerCount),
                    new SumAction(s.SmsCustomer, s.SmsCustomerCount),
                    new SumAction(s.CommenttAdd, s.CommenttAddCount),
                    new SumAction(s.IasMkguAdd, s.IasMkguAddCount),
                    new SumAction(s.FormsAdd, s.FormsAddCount),
                    new SumAction(s.PkpvdAdd, s.PkpvdAddCount),
                    new SumAction(s.SmevExecution, s.SmevExecutionCount)))
                .FirstOrDefaultAsync();
        }
        [HttpGet("[controller]/sum/services")]
        [SwaggerOperation(Summary = "Запрос получение cуммы по услугам сотрудника за день")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetEmployeeSumServicesResponseData>>> GetEmployeeSumServices([FromQuery] GetEmployeeSumRequestData requestData)
        {
            var validationResult = await requestData.ValidateAsync();
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.ErrorMessage());

            return await _repository.ArchivePremiumStepServices
                .Where(w => w.ArchivePremium.SprEmployeesId == requestData.EmployeeId && w.ArchivePremium.PeriodDate == requestData.Date)
                .Select(s => new GetEmployeeSumServicesResponseData(
                    s.ServiceName, new GetEmployeeSumActionResponseData(
                        new SumAction(s.ProcessingPremium, s.ProcessingPremiumCount),
                    new SumAction(s.ServiceAdd, s.ServiceAddCount),
                    new SumAction(s.CustomerAdd, s.CustomerAddCount),
                    new SumAction(s.DocumentScan, s.DocumentScanCount),
                    new SumAction(s.ServiceConsultation, s.ServiceConsultationCount),
                    new SumAction(s.ServiceExecuted, s.ServiceExecutedCount),
                    new SumAction(s.CallCustomer, s.CallCustomerCount),
                    new SumAction(s.SmsCustomer, s.SmsCustomerCount),
                    new SumAction(s.CommenttAdd, s.CommenttAddCount),
                    new SumAction(s.IasMkguAdd, s.IasMkguAddCount),
                    new SumAction(s.FormsAdd, s.FormsAddCount),
                    new SumAction(s.PkpvdAdd, s.PkpvdAddCount),
                    new SumAction(s.SmevExecution, s.SmevExecutionCount))))
                .ToListAsync();
        }
        #endregion
    }
}
