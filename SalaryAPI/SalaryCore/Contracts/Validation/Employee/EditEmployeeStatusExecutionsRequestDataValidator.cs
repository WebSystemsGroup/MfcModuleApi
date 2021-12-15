using FluentValidation;
using SalaryCore.Contracts.Employee;
using SalaryCore.Extensions;

namespace SalaryCore.Contracts.Validation.Employee
{
    public class EditEmployeeStatusExecutionsRequestDataValidator : AbstractValidator<EditEmployeeStatusExecutionsRequestData>
    {
        public EditEmployeeStatusExecutionsRequestDataValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Неверный индетификатор роли");
            RuleFor(x => x.DateStart)
                .CheckDate();
            RuleFor(x => x.DateStop)
                .CheckDate();
            RuleFor(x => x.IsExecution)
                .NotNull()
                .WithMessage("Неврное значение Статуса Исполнения");
        }
    }
}
