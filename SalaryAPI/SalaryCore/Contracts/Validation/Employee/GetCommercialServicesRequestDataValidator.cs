using FluentValidation;
using SalaryCore.Contracts.Employee;
using SalaryCore.Extensions;

namespace SalaryCore.Contracts.Validation.Employee
{
    public class GetCommercialServicesRequestDataValidator : AbstractValidator<GetCommercialServicesRequestData>
    {
        public GetCommercialServicesRequestDataValidator()
        {
            RuleFor(x => x.MfcId)
                .NotEmpty()
                .WithMessage("Неверный индетификатор МФЦ");
            RuleFor(x => x.EmployeeId)
                .NotEmpty()
                .WithMessage("Неверный индетификатор сотрудника");
            RuleFor(x => x.DateStart)
                .CheckDate();
            RuleFor(x => x.DateStop)
                .CheckDate();

        }
    }
}
