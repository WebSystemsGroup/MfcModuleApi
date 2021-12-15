using System;
using System.Collections.Generic;

namespace SalaryCore.Contracts.Employee
{
    public record GetJobPositionResponseData(int Id, string Name);
    public record GetStatusResponseData(int Id, string Name);
    public record GetRoleResponseData(int Id, string Name);
    public record GetOfficesResponseData(Guid OfficesId, string OfficeNameSmall);
    public record GetEmployeeResponseData(Guid EmployeesId, string EmployeeFio, string JobPositionName);
    public record GetSalaryMfcResponseData(Guid EmployeesId, string EmployeeFio, int JobPositionId, string JobPositionName, int PeriodCountDay,
        int Type, decimal EmployeesSalary, decimal EmployeesStake, decimal FineSum, decimal StepPremium,
        decimal StepPremiumOther, int CountDayWork);
    public record GetSalaryEmployeeResponseData(int JobPositionId, string JobPositionName, DateTime PeriodDate, int Type, 
        decimal EmployeesSalary, decimal EmployeesStake, decimal FineSum, decimal StepPremium, decimal StepPremiumOther, decimal StepPremiumTotal);

    public record GetEmployeeOfficesResponseData(Guid Id, string MfcName, string JobPositionName, DateTime DateStart, DateTime? DateStop,
        string EmployeeFioAdd);
    public record GetEmployeeJobPositionsResponseData(Guid Id, string JobPositionName, DateTime DateStart, DateTime? DateStop,
        decimal Salary, decimal Rate, decimal Intensity, decimal CostMinute, string EmployeeFioAdd, DateTime? DateAdd);

    public record GetEmployeeRoleResponseData(Guid Id, string RoleName, DateTime? DateStart, DateTime? DateStop, string EmployeeFioAdd, DateTime? DateAdd);
    public record GetEmployeeStatusResponseData(Guid Id, string StatusName, DateTime? DateStart, DateTime? DateStop, string EmployeeFioAdd, DateTime? DateAdd);
    public record GetEmployeeStatusExecutionsResponseData(Guid Id, bool IsExecution, DateTime? DateStart, DateTime? DateStop, string EmployeeFioAdd, DateTime? DateAdd);
    public record GetEmployeeJobPositionsCombinationResponseData(Guid Id, string JobPositionName, DateTime DateStart, DateTime? DateStop,
        decimal? Salary, decimal? Rate, decimal? Intensity, string EmployeeFioAdd, DateTime DateAdd);

    public record GetEmployeeSumActionResponseData(SumAction Processing, SumAction ServiceAdd, SumAction CustomerAdd,
        SumAction DocumentScan, SumAction Consultation, SumAction ServiceExecuted,
        SumAction CallCustomer, SumAction SmsCustomer, SumAction CommentAdd, SumAction IasMkguAdd,
        SumAction FormAdd, SumAction PkpvdAdd, SumAction SmevExecutions);

    public record GetEmployeeSumServicesResponseData(string ServiceName, GetEmployeeSumActionResponseData Action);

    public record SumAction (decimal Sum, int Count);

}
