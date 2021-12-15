using FluentValidation;
using SalaryCore.Contracts.Account;
using SalaryCore.Extensions;

namespace SalaryCore.Contracts.Validation.Account
{
    public class AuthenticateRequestDataValidator : AbstractValidator<AuthenticateRequestData>
    {
        public AuthenticateRequestDataValidator()
        {
            RuleFor(x => x.Login)
                .ValidateName("Логин обязателен для заполнения");

            RuleFor(x => x.Password)
                .ValidateName("Пароль обязателен для заполнения");
        }
    }
}
