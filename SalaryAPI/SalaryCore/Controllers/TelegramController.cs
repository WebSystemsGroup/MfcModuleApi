using DataLayer.Abstract;
using DataLayer.Entities.Functions;
using DataLayer.Extensions;
using DataLayer.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SalaryCore.Contracts.Telegram;
using SalaryCore.Extensions;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCore.Controllers
{
    /// <summary>
    /// Справочник "Сотрудники"
    /// </summary>
    [Route("api/[controller]/")]
    [Produces("application/json")]
    [ApiController]
    public class TelegramController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Справочник "Сотрудники"
        /// </summary>
        public TelegramController(IRepository repository, HttpClient httpClient) =>
            (_repository, _httpClient) = (repository, httpClient);

        /// <summary>
        /// Запрос реестра МФЦ
        /// </summary>
        /// <returns>Реестр офисов</returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("officesAll")]
        [SwaggerOperation(Summary = "Запрос реестра МФЦ")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetTelegramMfcResponseData>>> GetOffices()
        {
            return await _repository.SprQueueJoinMfcs
                  .AsNoTracking()
                  .Where(w => (bool)!w.SprEmployeesMfcNavigation.StructuralSubdivision)
                  .Select(s => new GetTelegramMfcResponseData(s.SprEmployeesMfcNavigation.Id, (int)s.SprMfcId,
                      s.SprEmployeesMfcNavigation.MfcNameSmall, s.SprEmployeesMfcNavigation.MfcAddress, s.SprEmployeesMfcNavigation.MfcWebsite,
                      s.SprEmployeesMfcNavigation.MfcTel, s.SprEmployeesMfcNavigation.MfcEmail))
                  .ToListAsync();
        }

        /// <summary>
        /// Запрос получения статуса обращения 
        /// </summary>
        /// <returns>Реестр офисов</returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("cases/{id}/status")]
        [SwaggerOperation(Summary = "Запрос получения статуса обращения")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CaseInfoGet>> GetCaseStatus(string id)
        {
            return await _repository.CaseInfoGets(id).AsNoTracking().FirstOrDefaultAsync();
        }

        /// <summary>
        /// Запрос получения даты для предварительной записи 
        /// </summary>
        /// <returns>Реестр офисов</returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpGet("preRegistration/date/")]
        [SwaggerOperation(Summary = "Запрос получения даты для предварительной записи")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetDatePreliminaryAppointmentResponseData>>> GetDatePreliminaryAppointment([FromQuery] int queueId)
        {
            if (!queueId.IsValidIdentifier() || !await _repository.SprQueueJoinMfcs.AnyAsync(a => a.SprMfcId == queueId))
                return BadRequest(ErrorDescription.InvalidInputParameters);

            var url = $"//192.168.34.196:81/api/offices/{queueId}/prerecord/";

            var request = new HttpRequestMessage(HttpMethod.Get, $"http:{url}")
            {
                Content = new StringContent(string.Empty,
                    Encoding.UTF8,
                    "application/json")
            };
            var response = await _httpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode) return BadRequest();
            var b = await response.Content.ReadAsStringAsync();

            var qts = JsonConvert.DeserializeObject<List<GetDatePreliminaryAppointmentResponseData>>(b);
            if (qts is null or { Count: 0 }) return NotFound("Записи не найдены");

            return qts;
        }

        /// <summary>
        /// Запрос добавления предварительной записи
        /// </summary>
        /// <returns>Реестр офисов</returns>
        /// <response code="200">В случае успешного выполнения запроса</response>
        /// <response code="500">В случае ошибки выполнения запроса</response>
        [HttpPost("preRegistration/{queueId}")]
        [SwaggerOperation(Summary = "Запрос добавления предварительной записи")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<AddPreliminaryAppointmentResponseData>> AddPreliminaryAppointment([FromRoute] int queueId, [FromBody] AddPreliminaryAppointmentRequestData requestData)
        {
            var validationResult = await requestData.ValidateAsync();

            if (!queueId.IsValidIdentifier() || !validationResult.IsValid || !await _repository.SprQueueJoinMfcs.AnyAsync(a => a.SprMfcId == queueId))
                return BadRequest(!validationResult.IsValid ? validationResult.Errors.ErrorMessage() : new { PropertyName = nameof(queueId), ErrorDescription.InvalidInputParameters });

            var url = $"//192.168.34.196:81/api/offices/{queueId}/prerecord/";

            var baseObj = new BasePreliminaryAppointment
            {
                fio = requestData.fio,
                phone = requestData.phone,
                service = requestData.service,
                date = requestData.date,
                time = requestData.time
            };

            var data = new StringContent(JsonConvert.SerializeObject(baseObj), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"http:{url}", data);

            var message = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode) return BadRequest(message);

            return JsonConvert.DeserializeObject<AddPreliminaryAppointmentResponseData>(message);
        }
    }
}
