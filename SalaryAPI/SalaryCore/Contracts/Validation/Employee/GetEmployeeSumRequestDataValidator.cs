using FluentValidation;
using SalaryCore.Contracts.Employee;
using SalaryCore.Extensions;

namespace SalaryCore.Contracts.Validation.Employee
{
    public class GetEmployeeSumRequestDataValidator : AbstractValidator<GetEmployeeSumRequestData>
    {
        public GetEmployeeSumRequestDataValidator()
        {
            
            RuleFor(x => x.EmployeeId)
                .NotEmpty()
                .WithMessage("Неверный индетификатор сотрудника");
       
            RuleFor(x => x.Date)
                .CheckDate();

        }
    }
}
