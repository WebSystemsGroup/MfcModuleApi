using System;

namespace SalaryCore.Contracts.AdminPanel
{
    public record AverageDataQueueResponse(Guid DateQueryId,DateTime DateQuery ,
        int WorkWindows, int DefferenceWorkWindows, bool IsDefferenceWorkWindows, double DefferencePercentWorkWindows,
        int ActiveOperators, int DefferenceActiveOperators, bool IsDefferenceActiveOperators, double DefferencePercentActiveOperators,
        int LongTimeQueue, int DefferenceLongTimeQueue, bool IsDefferenceLongTime, double DefferencePercentLongTime, int countOfficesLong,
        int LittleTimeQueue, int DefferenceLittleTimeQueue, bool IsDefferenceLittleTime, double DefferencePercentLittleTime, int countOfficesLiitle,
        string AverageTimeQueue, string DefferenceAverageTime, bool IsDefferenceAverageTime, double DefferencePercentAverageTime,
        string MaximumTimeQueue, string DefferenceMaximumTime, bool IsDefferenceMaximumTime, double DefferencePercentMaximumTime,
        string MinimumTimeQueue, string DefferenceMinimumTime, bool IsDefferenceMinimumTime, double DefferencePercentMinimumTime);

    public record StaticDataMfcResponse(int TotalMfc, int TotalTOSP, int AverageSalaryDirector, int AverageSalarySpecialist, int AverageSalaryOperator, string PopulationCoverage, string MonitoringQualities,
        int TotalWindowsMfc, int TotalWindowsWork);

   /* public record GetServicesPeriod(Guid DateQueryId, DateTime DateQueryAdd, int CountReceivedWeek, int CountExecutedWeek,  int CountReceivedMonth, 
        int CountExecutedMonth,  int CountReceivedQuarter,  int CountExecutedQuarter,  int CountReceivedYear,  int CountExecutedYear,  
       int ExecutionService, bool IsDefferenceExecution, double PercentExecutions,
       int CountExpired, bool IsDefferenceExpired, double PercentExpired,  
       int CountExpiredStage, bool IsDefferenceExpiredStage, double PercentExpiredStage);*/

    public record GetServicesPeriod(Guid DateQueryId, DateTime DateQueryAdd, int CountReceivedMonth, int CountExecutedMonth, 
    int ExecutionService, bool IsDefferenceExecution, int DefferenceExecutionService, double DefferencePercentExecutions,
    int CountExpired, double PercentExpired, bool IsDefferenceExpired, int DefferenceExpired, double DefferencePercentExpired,
    int CountExpiredStage, double PercentExpiredStage, bool IsDefferenceExpiredStage, int DefferenceExpiredStage, double DefferencePercentExpiredStage);

    public record GetServicesPercentStateTask(DateTime DateQuery, int CountService ,decimal Percent);

}
