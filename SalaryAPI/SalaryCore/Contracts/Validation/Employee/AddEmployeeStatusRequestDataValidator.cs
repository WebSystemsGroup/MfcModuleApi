using FluentValidation;
using SalaryCore.Contracts.Employee;
using SalaryCore.Extensions;

namespace SalaryCore.Contracts.Validation.Employee
{
    public class AddEmployeeStatusRequestDataValidator : AbstractValidator<AddEmployeeStatusRequestData>
    {
        public AddEmployeeStatusRequestDataValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Неверный индетификатор офиса");
            RuleFor(x => x.DateStart)
                .CheckDate();
            RuleFor(x => x.DateStop)
                .CheckDate();
            RuleFor(x => x.StatusId)
                .NotNull()
                .WithMessage("Неврное значение Статуса");
        }
    }
}
