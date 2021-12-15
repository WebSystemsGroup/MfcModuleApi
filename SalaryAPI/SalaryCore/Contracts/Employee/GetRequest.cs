using System;
using System.Threading.Tasks;
using FluentValidation.Results;
using SalaryCore.Contracts.Common;
using SalaryCore.Contracts.Validation.Employee;

namespace SalaryCore.Contracts.Employee
{
    public record GetSalaryMfcRequestData(Guid MfcId, int Month, int Year)
    {
        public async Task<ValidationResult> ValidateAsync() =>
            await new GetSalaryMfcRequestDataValidator().ValidateAsync(this);
    }

    public record GetSalaryEmployeeRequestData(Guid MfcId, Guid EmployeeId, int Month, int Year)
    {
        public async Task<ValidationResult> ValidateAsync() =>
            await new GetSalaryEmployeeRequestDataValidator().ValidateAsync(this);
    }

    public record GetSurveyingServicesRequestData(Guid MfcId, Guid EmployeeId, SurveyingServicesType Type, DateTime DateStart, DateTime DateStop)
    {
        public async Task<ValidationResult> ValidateAsync() =>
            await new GetSurveyingServicesRequestDataValidator().ValidateAsync(this);
    }

    public record GetCommercialServicesRequestData(Guid MfcId, Guid EmployeeId, DateTime DateStart, DateTime DateStop)
    {
        public async Task<ValidationResult> ValidateAsync() =>
            await new GetCommercialServicesRequestDataValidator().ValidateAsync(this);
    }
    public record GetReportSalarySurveyingRequestData(Guid MfcId, DateTime DateStart, DateTime DateStop)
    {
        public async Task<ValidationResult> ValidateAsync() =>
            await new GetReportSalarySurveyingRequestDataValidator().ValidateAsync(this);
    }
    public record GetReportSalaryCommercialRequestData(Guid? MfcId, Guid? EmployeeId, DateTime DateStart, DateTime DateStop)
    {
        public async Task<ValidationResult> ValidateAsync() =>
            await new GetReportSalaryCommerciaRequestDataValidator().ValidateAsync(this);
    }
    public record GetSalaryCalcOneEmployeesRequestData(Guid EmployeeId, DateTime DateStart, DateTime DateStop, int Type, bool IsSave)
    {
        public async Task<ValidationResult> ValidateAsync() =>
            await new GetSalaryCalcOneEmployeesRequestDataValidator().ValidateAsync(this);
    }
    public record AddEmployeeMfcRequestData(Guid MfcId, Guid EmployeeId, int JobPositionId, int StatusId, int RoleId, DateTime DateStart, 
        bool IsExecution, DateTime DateStop, decimal Salary, decimal Rate, decimal Intensity, decimal CostMinute)
    {
        public async Task<ValidationResult> ValidateAsync() =>
            await new AddEmployeeMfcRequestDataValidator().ValidateAsync(this);
    }

    public record EditEmployeeJobPositionsRequestData(Guid Id, int JobPositionId, DateTime DateStart, DateTime? DateStop,
        decimal Salary, decimal Rate, decimal Intensity, decimal CostMinute)
    {
    public async Task<ValidationResult> ValidateAsync() =>
        await new EditEmployeeJobPositionsRequestDataValidator().ValidateAsync(this);
    }

    public record AddEmployeeRoleRequestData(Guid Id, int RoleId, DateTime? DateStart, DateTime? DateStop)
    {
    public async Task<ValidationResult> ValidateAsync() =>
        await new AddEmployeeRoleRequestDataValidator().ValidateAsync(this);
    }
    public record EditEmployeeRoleRequestData(Guid Id, int RoleId, DateTime? DateStart, DateTime? DateStop)
    {
        public async Task<ValidationResult> ValidateAsync() =>
            await new EditEmployeeRoleRequestDataValidator().ValidateAsync(this);
    }
    public record AddEmployeeStatusRequestData(Guid Id, int StatusId, DateTime DateStart, DateTime? DateStop)
    {
        public async Task<ValidationResult> ValidateAsync() =>
            await new AddEmployeeStatusRequestDataValidator().ValidateAsync(this);
    }
    public record EditEmployeeStatusRequestData(Guid Id, int StatusId, DateTime DateStart, DateTime? DateStop)
    {
        public async Task<ValidationResult> ValidateAsync() =>
            await new EditEmployeeStatusRequestDataValidator().ValidateAsync(this);
    }
    public record AddEmployeeStatusExecutionsRequestData(Guid Id, bool IsExecution, DateTime DateStart, DateTime? DateStop)
    {
        public async Task<ValidationResult> ValidateAsync() =>
            await new AddEmployeeStatusExecutionsRequestDataValidator().ValidateAsync(this);
    }
    public record EditEmployeeStatusExecutionsRequestData(Guid Id, bool IsExecution, DateTime DateStart, DateTime? DateStop)
    {
        public async Task<ValidationResult> ValidateAsync() =>
            await new EditEmployeeStatusExecutionsRequestDataValidator().ValidateAsync(this);
    }
    public record AddEmployeeJobPositionCombinationRequestData(Guid Id, int JobPositionId, DateTime DateStart, DateTime DateStop,
        decimal Salary, decimal Rate, decimal Intensity)
    {
        public async Task<ValidationResult> ValidateAsync() =>
            await new AddEmployeeJobPositionCombinationRequestDataValidator().ValidateAsync(this);
    }
    public record GetEmployeeSumRequestData(Guid EmployeeId, DateTime Date)
    {
        public async Task<ValidationResult> ValidateAsync() =>
            await new GetEmployeeSumRequestDataValidator().ValidateAsync(this);
    }


}
