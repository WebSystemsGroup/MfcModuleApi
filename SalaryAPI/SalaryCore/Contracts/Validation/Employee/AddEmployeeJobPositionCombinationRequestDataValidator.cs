using FluentValidation;
using SalaryCore.Contracts.Employee;
using SalaryCore.Extensions;

namespace SalaryCore.Contracts.Validation.Employee
{
    public class AddEmployeeJobPositionCombinationRequestDataValidator : AbstractValidator<AddEmployeeJobPositionCombinationRequestData>
    {
        public AddEmployeeJobPositionCombinationRequestDataValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Неверный индетификатор МФЦ");
            RuleFor(x => x.DateStart)
                .CheckDate();
            RuleFor(x => x.DateStop)
                .CheckDate();
            RuleFor(x => x.Intensity)
                .NotNull()
                .WithMessage("Неврное значение интенсивности");
            RuleFor(x => x.Rate)
                .NotNull()
                .WithMessage("Неврное значение ставки");
            RuleFor(x => x.Salary)
                .NotNull()
                .WithMessage("Неврное значение оклада");
            RuleFor(x => x.JobPositionId)
                .NotNull()
                .WithMessage("Неврное значение Должности");
        }
    }
}
