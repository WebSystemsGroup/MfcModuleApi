using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchivePremium
    {
        public ArchivePremium()
        {
            ArchivePremiumFineSums = new HashSet<ArchivePremiumFineSum>();
            ArchivePremiumStepServices = new HashSet<ArchivePremiumStepService>();
            ArchivePremiumStepSums = new HashSet<ArchivePremiumStepSum>();
        }

        public Guid Id { get; set; }
        public Guid SprEmployeesId { get; set; }
        public int SprEmployeesJobPosId { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public DateTime PeriodDate { get; set; }
        public int PeriodMonth { get; set; }
        public int PeriodYear { get; set; }
        public decimal FinePercent { get; set; }
        public decimal EmployeesSalary { get; set; }
        public decimal EmployeesStake { get; set; }
        public string EmployeesFio { get; set; }
        public string EmployeesMfcName { get; set; }
        public string EmployeesJobPosName { get; set; }
        public DateTime SetDate { get; set; }
        public decimal FineSum { get; set; }
        public decimal EmployeesPremium { get; set; }
        public decimal EmployeesPremiumTotal { get; set; }
        public decimal StepPremium { get; set; }
        public decimal StepPremiumOther { get; set; }
        public short? PeriodCountDay { get; set; }
        public short? Type { get; set; }
        public decimal? EmployeesPremiumIasMkgu { get; set; }
        public decimal? EmployeesPremiumIasMkguOur { get; set; }
        public decimal? EmployeesPremiumQueue { get; set; }

        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprEmployeesJobPo SprEmployeesJobPos { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual ICollection<ArchivePremiumFineSum> ArchivePremiumFineSums { get; set; }
        public virtual ICollection<ArchivePremiumStepService> ArchivePremiumStepServices { get; set; }
        public virtual ICollection<ArchivePremiumStepSum> ArchivePremiumStepSums { get; set; }
    }
}
