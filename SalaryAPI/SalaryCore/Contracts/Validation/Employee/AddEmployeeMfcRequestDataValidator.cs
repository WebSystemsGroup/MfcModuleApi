using FluentValidation;
using SalaryCore.Contracts.Employee;
using SalaryCore.Extensions;

namespace SalaryCore.Contracts.Validation.Employee
{
    public class AddEmployeeMfcRequestDataValidator : AbstractValidator<AddEmployeeMfcRequestData>
    {
        public AddEmployeeMfcRequestDataValidator()
        {
            RuleFor(x => x.MfcId)
                .NotEmpty()
                .WithMessage("Неверный индетификатор офиса");
            RuleFor(x => x.EmployeeId)
                .NotEmpty()
                .WithMessage("Неверный индетификатор Сотрудника");
            RuleFor(x => x.DateStart)
                .CheckDate();
            RuleFor(x => x.DateStop)
                .CheckDate();
            RuleFor(x => x.IsExecution)
                .NotNull()
                .WithMessage("Неврное значение исполнения");
            RuleFor(x => x.Intensity)
                .NotNull()
                .WithMessage("Неврное значение интенсивности");
            RuleFor(x => x.CostMinute)
                .NotNull()
                .WithMessage("Неврное значение стоимость минуты");
            RuleFor(x => x.Rate)
                .NotNull()
                .WithMessage("Неврное значение ставки");
            RuleFor(x => x.Salary)
                .NotNull()
                .WithMessage("Неврное значение оклада");
            RuleFor(x => x.RoleId)
                .NotNull()
                .WithMessage("Неврное значение роли");
            RuleFor(x => x.StatusId)
                .NotNull()
                .WithMessage("Неврное значение Статуса");
            RuleFor(x => x.JobPositionId)
                .NotNull()
                .WithMessage("Неврное значение Должности");
        }
    }
}
