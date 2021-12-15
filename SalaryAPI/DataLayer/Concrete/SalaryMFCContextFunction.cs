using DataLayer.Entities;
using DataLayer.Entities.Functions;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Concrete
{
    public partial class SalaryMFCContext
    {
        public virtual DbSet<ReportSalarySurveyingReestrServices> ReportSalarySurveyingReestrServices { get; set; }
        public virtual DbSet<ReportSalaryComercialReestrServices> ReportSalaryComercialReestrServices { get; set; }
        public virtual DbSet<ReportSalarySurveying> ReportSalarySurveying { get; set; }
        public virtual DbSet<ReportSalaryCommercial> ReportSalaryCommercial { get; set; }
        public virtual DbSet<SalaryCalcOneEmployees> SalaryCalcOneEmployees { get; set; }
        public virtual DbSet<ApiExecutedServices> ApiExecutedServices { get; set; }
        public virtual DbSet<ApiReceivedServices> ApiReceivedServices { get; set; }
        public virtual DbSet<ApiServicesDay> ApiServicesDays { get; set; }
        public virtual DbSet<ApiExpiredServices> ApiExpiredServices { get; set; }
        public virtual DbSet<ApiExpiredStage> ApiExpiredStages { get; set; }
        public virtual DbSet<ApiStateTaskServices> ApiStateTaskServices { get; set; }
        public virtual DbSet<CaseInfoGet> CaseInfoGets { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReportSalarySurveyingReestrServices>(entity => { entity.HasNoKey(); });
            modelBuilder.Entity<ReportSalaryComercialReestrServices>(entity => { entity.HasNoKey(); });
            modelBuilder.Entity<ReportSalarySurveying>(entity => { entity.HasNoKey(); });
            modelBuilder.Entity<ReportSalaryCommercial>(entity => { entity.HasNoKey(); });
            modelBuilder.Entity<SalaryCalcOneEmployees>(entity => { entity.HasNoKey(); });

            modelBuilder.Entity<ApiExecutedServices>(entity => { entity.HasNoKey(); });
            modelBuilder.Entity<ApiReceivedServices>(entity => { entity.HasNoKey(); });
            modelBuilder.Entity<ApiServicesDay>(entity => { entity.HasNoKey(); });
            modelBuilder.Entity<ApiExpiredServices>(entity => { entity.HasNoKey(); });
            modelBuilder.Entity<ApiExpiredStage>(entity => { entity.HasNoKey(); });
            modelBuilder.Entity<ApiStateTaskServices>(entity => { entity.HasNoKey(); });

            modelBuilder.Entity<CaseInfoGet>(entity => { entity.HasNoKey(); });

        }

    }
}
