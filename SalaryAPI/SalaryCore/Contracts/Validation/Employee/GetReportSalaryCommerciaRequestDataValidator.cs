using FluentValidation;
using SalaryCore.Contracts.Employee;
using SalaryCore.Extensions;

namespace SalaryCore.Contracts.Validation.Employee
{
    public class GetReportSalaryCommerciaRequestDataValidator : AbstractValidator<GetReportSalaryCommercialRequestData>
    {
        public GetReportSalaryCommerciaRequestDataValidator()
        {
            RuleFor(x => x.MfcId)
                .NotEmpty()
                .When(x=>x.MfcId is not null)
                .WithMessage("Неверный индетификатор МФЦ");
            RuleFor(x => x.EmployeeId)
                .NotEmpty()
                .When(x=>x.EmployeeId is not null)
                .WithMessage("Неверный индетификатор сотрудника");
            RuleFor(x => x.DateStart)
                .CheckDate();
            RuleFor(x => x.DateStop)
                .CheckDate();

        }
    }
}
