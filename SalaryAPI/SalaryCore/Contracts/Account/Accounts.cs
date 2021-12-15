using FluentValidation.Results;
using SalaryCore.Contracts.Validation.Account;
using System.Threading.Tasks;

namespace SalaryCore.Contracts.Account
{
    public record AuthenticateRequestData(string Login, string Password)
    {
        public async Task<ValidationResult> ValidateAsync() =>
            await new AuthenticateRequestDataValidator().ValidateAsync(this);
    }
    public record RefreshTokenRequestData(string AccessToken, string RefreshToken)
    {
        public async Task<ValidationResult> ValidateAsync() =>
            await new RefreshTokenRequestDataValidator().ValidateAsync(this);
    }

    /// <summary>
    /// Ответ на запрос авторизации пользователя
    /// </summary>
    public record AuthenticateResponseData(string AccessToken, string RefreshToken);
}
