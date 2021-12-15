using FluentValidation;
using SalaryCore.Contracts.Account;
using SalaryCore.Extensions;

namespace SalaryCore.Contracts.Validation.Account
{
    public class RefreshTokenRequestDataValidator : AbstractValidator<RefreshTokenRequestData>
    {
        public RefreshTokenRequestDataValidator()
        {
            RuleFor(x => x.AccessToken)
                .ValidateName("Логин обязателен для заполнения");

            RuleFor(x => x.RefreshToken)
                .ValidateName("Пароль обязателен для заполнения");
        }
    }
}
