using FluentValidation;
using SalaryCore.Contracts.Employee;
using SalaryCore.Extensions;

namespace SalaryCore.Contracts.Validation.Employee
{
    public class GetSalaryCalcOneEmployeesRequestDataValidator : AbstractValidator<GetSalaryCalcOneEmployeesRequestData>
    {
        public GetSalaryCalcOneEmployeesRequestDataValidator()
        {
            RuleFor(x => x.EmployeeId)
                .NotEmpty()
                .WithMessage("Неверный индетификатор Сотрудника");
            RuleFor(x => x.DateStart)
                .CheckDate();
            RuleFor(x => x.DateStop)
                .CheckDate();
            RuleFor(x => x.Type)
                .NotNull()
                .WithMessage("Неврное значение типа");
            RuleFor(x => x.IsSave)
                .NotNull()
                .WithMessage("Неврное значение сохранения");

        }
    }
}
