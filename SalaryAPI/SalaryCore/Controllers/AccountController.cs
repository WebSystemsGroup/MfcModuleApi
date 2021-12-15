using DataLayer.Abstract;
using DataLayer.Entities.Models;
using DataLayer.Extensions;
using DataLayer.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalaryCore.Contracts.Account;
using SalaryCore.Extensions;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.JWT;

namespace SalaryCore.Controllers
{
    public class AccountController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly IJwtToken _jwtUtils;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="jwtUtils"></param>
        public AccountController(IRepository repository, IJwtToken jwtUtils) =>
            (_repository, _jwtUtils) = (repository, jwtUtils);

        /// <summary>
        /// Запрос авторизации пользователя
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        /// <response code="200">Запрос выполнен успешно</response>
        /// <response code="400">Не валидные входные параметры или пароль</response>
        /// <response code="404">Сотрудник не найдена</response>
        /// <response code="500">Ошибка выполнения запроса</response>
        [SwaggerOperation(Summary = "Запрос авторизации пользователя")]
        [HttpPost("token")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<AuthenticateResponseData>> Authenticate([FromForm] AuthenticateRequestData requestData)
        {

            const string noName = "123456";

            var validationResult = await requestData.ValidateAsync();
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.ErrorMessage());

            var employee = await _repository.SprEmployees
                .Select(s => new
                {
                    s.Id,
                    s.EmployeeLogin,
                    s.EmployeePass
                    //RoleId = s.SEmployeesRoles.OrderByDescending(o => o.DateAdd).FirstOrDefault().SRolesId
                })
                .FirstOrDefaultAsync(fd => fd.EmployeeLogin == requestData.Login.ToLower());
            if (employee is null) return Unauthorized("Пользователь не найден.");

            if (await DataUtils.Encrypt(noName) != await DataUtils.Encrypt(requestData.Password))
                return BadRequest("Неверный пароль.");

            var token = _jwtUtils.GenerateAccessToken(employee.Id);
            var refreshToken = _jwtUtils.GenerateRefreshToken();

            if (ValidationUtils.IsValidName(token) || ValidationUtils.IsValidName(refreshToken))
                return BadRequest("Ошибка генерации токена.");

            _repository.Insert(new RefreshToken
            {
                Id = Guid.NewGuid(),
                RefreshToken1 = refreshToken,
                ExpireTime = DateTime.UtcNow.AddMonths(1),
                SprEmployeesId = employee.Id,
                Used = false
            });

            return new AuthenticateResponseData(token, refreshToken);
        }

        /// <summary>
        /// Запрос обновления токена авторизации
        /// </summary>
        /// <param name="requestData">Данные запроса</param>
        /// <returns></returns>
        /// <response code="200">Запрос выполнен успешно</response>
        /// <response code="400">Не валидные входные параметры</response>
        /// <response code="404">Токен обновления не найдена</response>
        /// <response code="500">Ошибка выполнения запроса</response>
        [HttpPost("refresh")]
        [SwaggerOperation(Summary = "Запрос обновления токена авторизации")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<AuthenticateResponseData>> RefreshToken([FromForm] RefreshTokenRequestData requestData)
        {
            var validationResult = await requestData.ValidateAsync();
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors.ErrorMessage());

            if (!_jwtUtils.ValidateToken(requestData.AccessToken)) return BadRequest("Не валидный токен.");

            var authUserId = _jwtUtils.CreateAuthenticatedUserInfo(requestData.AccessToken);

            var refreshToken = await _repository.RefreshTokens.FirstOrDefaultAsync(sd =>
                sd.SprEmployeesId == authUserId && sd.RefreshToken1 == requestData.RefreshToken &&
                !sd.Used);

            if (refreshToken is null) return BadRequest("Токен обновления не найден.");
            if (refreshToken.IsExpired()) return BadRequest("Истек срок токена обновления.");

            var newAccessToken = _jwtUtils.GenerateAccessToken(authUserId);
            var newRefreshToken = requestData.RefreshToken;

            if (refreshToken.ExpireTime.Subtract(DateTime.Now).Days > 1)
                return new AuthenticateResponseData(newAccessToken, newRefreshToken);

            newRefreshToken = _jwtUtils.GenerateRefreshToken();

            _repository.Insert(new RefreshToken
            {
                Id = Guid.NewGuid(),
                SprEmployeesId = authUserId,
                RefreshToken1 = newRefreshToken,
                ExpireTime = DateTime.Now.AddMonths(1),
                Used = false
            });

            refreshToken.Used = true;

            _repository.Update(refreshToken);

            return new AuthenticateResponseData(newAccessToken, newRefreshToken);
        }
    }
}
