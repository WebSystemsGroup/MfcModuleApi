using FluentValidation;
using SalaryCore.Contracts.Employee;
using SalaryCore.Extensions;

namespace SalaryCore.Contracts.Validation.Employee
{
    public class AddEmployeeRoleRequestDataValidator : AbstractValidator<AddEmployeeRoleRequestData>
    {
        public AddEmployeeRoleRequestDataValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Неверный индетификатор офиса");
            RuleFor(x => x.DateStart)
                .CheckDate();
            RuleFor(x => x.DateStop)
                .CheckDate();
            RuleFor(x => x.RoleId)
                .NotNull()
                .WithMessage("Неврное значение Роли");
        }
    }
}
