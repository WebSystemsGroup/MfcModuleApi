using FluentValidation;
using SalaryCore.Contracts.Employee;
using SalaryCore.Extensions;

namespace SalaryCore.Contracts.Validation.Employee
{
    public class EditEmployeeStatusRequestDataValidator : AbstractValidator<EditEmployeeStatusRequestData>
    {
        public EditEmployeeStatusRequestDataValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Неверный индетификатор роли");
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
