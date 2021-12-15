using FluentValidation;
using SalaryCore.Contracts.Employee;
using SalaryCore.Extensions;

namespace SalaryCore.Contracts.Validation.Employee
{
    public class EditEmployeeRoleRequestDataValidator : AbstractValidator<EditEmployeeRoleRequestData>
    {
        public EditEmployeeRoleRequestDataValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Неверный индетификатор роли");
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
