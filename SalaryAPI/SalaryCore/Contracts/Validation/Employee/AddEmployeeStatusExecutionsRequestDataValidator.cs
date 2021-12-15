using FluentValidation;
using SalaryCore.Contracts.Employee;
using SalaryCore.Extensions;

namespace SalaryCore.Contracts.Validation.Employee
{
    public class AddEmployeeStatusExecutionsRequestDataValidator : AbstractValidator<AddEmployeeStatusExecutionsRequestData>
    {
        public AddEmployeeStatusExecutionsRequestDataValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Неверный индетификатор офиса");
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
