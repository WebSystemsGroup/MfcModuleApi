using System;
using FluentValidation;
using SalaryCore.Contracts.Employee;

namespace SalaryCore.Contracts.Validation.Employee
{
    public class GetSalaryMfcRequestDataValidator : AbstractValidator<GetSalaryMfcRequestData>
    {
        public GetSalaryMfcRequestDataValidator()
        {
            RuleFor(x => x.MfcId)
                .NotEmpty()
                .WithMessage("Неверный индетификатор МФЦ");
            RuleFor(x => x.Month)
                .InclusiveBetween(1, 12)
                .WithMessage("Неверное значение месяца");
            RuleFor(x => x.Year)
                .Must(x => x <= DateTime.Now.Year && x >= DateTime.MinValue.Year)
                .WithMessage("Неверное значение года");
        }
    }
}
