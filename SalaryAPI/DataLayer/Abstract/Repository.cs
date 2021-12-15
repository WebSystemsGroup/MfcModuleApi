using DataLayer.Concrete;
using DataLayer.Entities;
using DataLayer.Entities.Functions;
using DataLayer.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
    internal class Repository : IRepository
    {
        private readonly SalaryMFCContext _context;

        public Repository(SalaryMFCContext context)
        {
            _context = context;
        }

        public async Task<AuthenticatedUserInfo> AuthenticatedUserInfo(Guid id)
        {
            return await _context.SprEmployees.Select(s => new AuthenticatedUserInfo
            {
                Id = s.Id,
                Fio = s.EmployeeFio,
                OfficeInfo = s.SprEmployeesMfcJoins.Where(w => w.DateStop != null || w.DateStop > DateTime.Now).Select(ss => new AuthenticatedUserInfo.Office
                {
                    OfficeId = ss.SprEmployeesMfcId,
                    OfficeMnemo = ss.SprEmployeesMfc.MfcMnemo,
                }).First()
            }).FirstOrDefaultAsync(f => f.Id == id) ?? throw new("Данные пользователя не найдены");
        }

        public IDbContextTransaction BeginTransaction() => _context.Database.BeginTransaction();
        public IQueryable<RefreshToken> RefreshTokens => _context.RefreshTokens;
        public IQueryable<SprEmployee> SprEmployees => _context.SprEmployees;
        public IQueryable<SprEmployeesMfc> SprEmployeesMfcs => _context.SprEmployeesMfcs;
        public IQueryable<SprEmployeesMfcJoin> SprEmployeesMfcJoins => _context.SprEmployeesMfcJoins;
        public IQueryable<ArchivePremium> ArchivePremiums => _context.ArchivePremia;
        public IQueryable<SprQueueJoinMfc> SprQueueJoinMfcs => _context.SprQueueJoinMfcs;
        public IQueryable<SprEmployeesJobPo> SprEmployeesJobPos => _context.SprEmployeesJobPos;
        public IQueryable<SprEmployeesStatus> SprEmployeesStatus => _context.SprEmployeesStatuses;
        public IQueryable<SprEmployeesRole> SprEmployeesRoles => _context.SprEmployeesRoles;
        public IQueryable<SprEmployeesSalary> SprEmployeesSalaries => _context.SprEmployeesSalaries;
        public IQueryable<SprEmployeesRoleJoin> SprEmployeesRoleJoins => _context.SprEmployeesRoleJoins;
        public IQueryable<SprEmployeesStatusJoin> SprEmployeesStatusJoins => _context.SprEmployeesStatusJoins;
        public IQueryable<SprEmployeesExecution> SprEmployeesExecutions => _context.SprEmployeesExecutions;
        public IQueryable<SprEmployeesJobPosCombination> SprEmployeesJobPosCombinations => _context.SprEmployeesJobPosCombinations;
        public IQueryable<ArchivePremiumStepSum> ArchivePremiumStepSums => _context.ArchivePremiumStepSums;
        public IQueryable<ArchivePremiumStepService> ArchivePremiumStepServices => _context.ArchivePremiumStepServices;
        public IQueryable<ApiManagerPanelStateTask> ApiManagerPanelStateTasks => _context.ApiManagerPanelStateTasks;
        public IQueryable<ApiManagerPanelQueueInfo> ApiManagerPanelQueueInfos => _context.ApiManagerPanelQueueInfos;
        public IQueryable<ApiManagerPanelActiveOperator> ApiManagerPanelActiveOperators => _context.ApiManagerPanelActiveOperators;
        public IQueryable<ApiManagerPanelQueue> ApiManagerPanelQueues => _context.ApiManagerPanelQueues;
        public IQueryable<ApiManagerPanelServicePeriod> ApiManagerPanelServicePeriods => _context.ApiManagerPanelServicePeriods;
        public IQueryable<ApiManagerPanelServiceDate> ApiManagerPanelServiceDates => _context.ApiManagerPanelServiceDates;
        public IQueryable<SprEmployeesAuthorizationLog> SprEmployeesAuthorizationLogs => _context.SprEmployeesAuthorizationLogs;
        public IQueryable<DataService> DataServices => _context.DataServices;
        public IQueryable<ReportSalarySurveyingReestrServices> GetReportSalarySurveyingReestrServicess(Guid mfcId, Guid employeId, int type, DateTime dateStart, DateTime dateStop) =>
           _context.ReportSalarySurveyingReestrServices.FromSqlInterpolated($"SELECT * FROM public.report_salary_surveying_reestr_services({mfcId},{employeId},{type},{dateStart}::date,{dateStop}::date)");
        public IQueryable<ReportSalaryComercialReestrServices> GetReportSalaryComercialReestrServices(Guid mfcId, Guid employeId, DateTime dateStart, DateTime dateStop) =>
            _context.ReportSalaryComercialReestrServices.FromSqlInterpolated($"SELECT * FROM public.report_salary_comercial_reestr_services({mfcId},{employeId},{dateStart}::date,{dateStop}::date)");
        public IQueryable<ReportSalarySurveying> GetReportSalarySurveying(Guid mfcId, DateTime dateStart, DateTime dateStop) =>
            _context.ReportSalarySurveying.FromSqlInterpolated($"SELECT * FROM public.report_salary_surveying({mfcId},{dateStart}::date,{dateStop}::date)");
        public IQueryable<ReportSalaryCommercial> GetReportSalaryCommercial(Guid? mfcId, Guid? employeId, DateTime dateStart, DateTime dateStop) =>
            _context.ReportSalaryCommercial.FromSqlInterpolated($"SELECT * FROM public.report_salary_comercial_services( {mfcId}::uuid, {employeId}::uuid,{dateStart}::date,{dateStop}::date)");
        public IQueryable<SalaryCalcOneEmployees> GetSalaryCalcOneEmployees(Guid employeId, DateTime dateStart,
            DateTime dateStop, int type, bool isSave) => _context.SalaryCalcOneEmployees.FromSqlInterpolated(
            $"SELECT * FROM public.salary_calc_one_employees({employeId},{dateStart}::date,{dateStop}::date, {type}::smallint, {isSave})");
        public IQueryable<ApiReceivedServices> GetApiReceivedServices =>
            _context.ApiReceivedServices.FromSqlInterpolated($"SELECT * FROM public.api_received_services()");
        public IQueryable<ApiExecutedServices> GetApiExecutedServices =>
            _context.ApiExecutedServices.FromSqlInterpolated($"SELECT * FROM public.api_executed_services()");
        public IQueryable<ApiServicesDay> GetApiServicesDays =>
            _context.ApiServicesDays.FromSqlInterpolated($"SELECT * FROM public.api_services_day()");
        public IQueryable<ApiExpiredServices> GetApiExpiredServices =>
            _context.ApiExpiredServices.FromSqlInterpolated($"SELECT * FROM public.api_expired_services()");
        public IQueryable<ApiExpiredStage> GetApiExpiredStages =>
            _context.ApiExpiredStages.FromSqlInterpolated($"SELECT * FROM public.api_expired_stage()");
        public IQueryable<ApiStateTaskServices> GetApiStateTaskServices =>
            _context.ApiStateTaskServices.FromSqlInterpolated($"SELECT * FROM public.api_state_task_services()");

        public IQueryable<CaseInfoGet> CaseInfoGets (string caseId) =>
            _context.CaseInfoGets.FromSqlInterpolated($"SELECT * FROM public.case_info_get({caseId},null::uuid)");

        #region |-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-[  Универсальные методы CRUD ]-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|       
        /// <summary>
        /// Поиска сущности по идентификатору
        /// </summary>
        /// <typeparam name="TEntity">Тип сущности</typeparam>
        /// <param name="id">Идентификатор для поиска</param>
        /// <returns></returns>
        public async Task<TEntity> FindAsync<TEntity>(Guid id) where TEntity : class => await _context.FindAsync<TEntity>(id);

        /// <summary>
        /// Поиска сущности по идентификатору
        /// </summary>
        /// <typeparam name="TEntity">Тип сущности</typeparam>
        /// <param name="id">Идентификатор для поиска</param>
        /// <returns></returns>
        public async Task<TEntity> FindAsync<TEntity>(int id) where TEntity : class => await _context.FindAsync<TEntity>(id);

        /// <summary>
        /// Поиска сущности по идентификатору
        /// </summary>
        /// <typeparam name="TEntity">Тип сущности</typeparam>
        /// <param name="id">Идентификатор для поиска</param>
        /// <returns></returns>
        public async Task<TEntity> FindAsync<TEntity>(string id) where TEntity : class => await _context.FindAsync<TEntity>(id);

        /// <summary>
        /// Создание универсального метода вставки
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        public void Insert<TEntity>(TEntity entity) where TEntity : class
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.SaveChanges();
        }

        /// <summary>
        /// Запись нескольких полей в БД
        /// </summary>
        public void Inserts<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
        {
            foreach (TEntity entity in entities)
                _context.Entry(entity).State = EntityState.Added;
            _context.SaveChanges();
        }

        /// <summary>
        /// Универсальный метод обновления
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        public void Update<TEntity>(TEntity entity)
            where TEntity : class
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        /// <summary>
        /// Универсальный метод удаления данных
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        public void Delete<TEntity>(TEntity entity)
            where TEntity : class
        {
            _context.Entry(entity).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        /// <summary>
        /// Универсальный метод удаления множество данных
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entities"></param>
        public void Deletes<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
        {
            foreach (TEntity entity in entities)
                _context.Entry(entity).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        #endregion
    }
}
