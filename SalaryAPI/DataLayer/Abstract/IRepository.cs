using System;
using System.Collections.Generic;
using DataLayer.Entities.Models;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Entities;
using DataLayer.Entities.Functions;
using Microsoft.EntityFrameworkCore.Storage;

namespace DataLayer.Abstract
{
    public interface IRepository
    {
        public IDbContextTransaction BeginTransaction();

        public Task<AuthenticatedUserInfo> AuthenticatedUserInfo(Guid id);

        public IQueryable<RefreshToken> RefreshTokens { get; }
        public IQueryable<SprEmployee> SprEmployees { get; }
        public IQueryable<SprEmployeesMfc> SprEmployeesMfcs { get; }
        public IQueryable<SprEmployeesMfcJoin> SprEmployeesMfcJoins { get; }
        public IQueryable<ArchivePremium> ArchivePremiums { get; }
        public IQueryable<SprQueueJoinMfc> SprQueueJoinMfcs { get; }
        public IQueryable<SprEmployeesJobPo> SprEmployeesJobPos { get; }
        public IQueryable<SprEmployeesStatus> SprEmployeesStatus { get; }
        public IQueryable<SprEmployeesRole> SprEmployeesRoles { get; }
        public IQueryable<SprEmployeesSalary> SprEmployeesSalaries { get; }
        public IQueryable<SprEmployeesRoleJoin> SprEmployeesRoleJoins { get; }
        public IQueryable<SprEmployeesStatusJoin> SprEmployeesStatusJoins { get; }
        public IQueryable<SprEmployeesExecution> SprEmployeesExecutions { get; }
        public IQueryable<SprEmployeesJobPosCombination> SprEmployeesJobPosCombinations { get; }
        public IQueryable<ArchivePremiumStepSum> ArchivePremiumStepSums { get; }
        public IQueryable<ArchivePremiumStepService> ArchivePremiumStepServices { get; }
        public IQueryable<ApiManagerPanelStateTask> ApiManagerPanelStateTasks { get; }
        public IQueryable<ApiManagerPanelQueueInfo> ApiManagerPanelQueueInfos { get; }
        public IQueryable<ApiManagerPanelActiveOperator> ApiManagerPanelActiveOperators { get; }
        public IQueryable<ApiManagerPanelQueue> ApiManagerPanelQueues { get; }
        public IQueryable<ApiManagerPanelServicePeriod> ApiManagerPanelServicePeriods { get; }
        public IQueryable<ApiManagerPanelServiceDate> ApiManagerPanelServiceDates { get; }
        public IQueryable<SprEmployeesAuthorizationLog> SprEmployeesAuthorizationLogs { get; }
        public IQueryable<ReportSalarySurveyingReestrServices> GetReportSalarySurveyingReestrServicess(Guid mfcId,
            Guid employeId, int type, DateTime dateStart, DateTime dateStop);
        public IQueryable<ReportSalaryComercialReestrServices> GetReportSalaryComercialReestrServices(Guid mfcId,
            Guid employeId, DateTime dateStart, DateTime dateStop);
        public IQueryable<ReportSalarySurveying> GetReportSalarySurveying(Guid mfcId, DateTime dateStart, DateTime dateStop);
        public IQueryable<ReportSalaryCommercial> GetReportSalaryCommercial(Guid? mfcId, Guid? employeId, DateTime dateStart, DateTime dateStop);
        public IQueryable<SalaryCalcOneEmployees> GetSalaryCalcOneEmployees(Guid employeId, DateTime dateStart, DateTime dateStop, int type, bool isSave);
        public IQueryable<ApiServicesDay> GetApiServicesDays { get; }
        public IQueryable<ApiReceivedServices> GetApiReceivedServices { get; }
        public IQueryable<ApiExecutedServices> GetApiExecutedServices { get;}
        public IQueryable<ApiExpiredServices> GetApiExpiredServices { get;}
        public IQueryable<ApiExpiredStage> GetApiExpiredStages { get; }
        public IQueryable<ApiStateTaskServices> GetApiStateTaskServices { get; }
        public IQueryable<DataService> DataServices { get; }

        public IQueryable<CaseInfoGet> CaseInfoGets(string caseId);

        #region |-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-[  Универсальные методы CRUD  ]-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|
        Task<TEntity> FindAsync<TEntity>(Guid id) where TEntity : class;
        Task<TEntity> FindAsync<TEntity>(int id) where TEntity : class;
        Task<TEntity> FindAsync<TEntity>(string id) where TEntity : class;
        void Insert<TEntity>(TEntity entity) where TEntity : class;
        void Inserts<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;
        void Update<TEntity>(TEntity entity) where TEntity : class;
        void Delete<TEntity>(TEntity entity) where TEntity : class;
        void Deletes<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;
        #endregion
    }
}
