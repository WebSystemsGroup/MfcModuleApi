using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprEmployeesJobPo
    {
        public SprEmployeesJobPo()
        {
            ArchivePremia = new HashSet<ArchivePremium>();
            ArchivePremiumSteps = new HashSet<ArchivePremiumStep>();
            ArchiveServiceSprEmployeesJobPos = new HashSet<ArchiveService>();
            ArchiveServiceSprEmployeesJobPosIdExecutionNavigations = new HashSet<ArchiveService>();
            ArchiveServicesFileResults = new HashSet<ArchiveServicesFileResult>();
            ArchiveServicesRoutesStages = new HashSet<ArchiveServicesRoutesStage>();
            DataPremiumFines = new HashSet<DataPremiumFine>();
            DataPremiumSteps = new HashSet<DataPremiumStep>();
            DataServiceSprEmployeesJobPos = new HashSet<DataService>();
            DataServiceSprEmployeesJobPosIdExecutionNavigations = new HashSet<DataService>();
            DataServicesFileResults = new HashSet<DataServicesFileResult>();
            DataServicesRoutesStages = new HashSet<DataServicesRoutesStage>();
            DataTestQuestionEmployees = new HashSet<DataTestQuestionEmployee>();
            DataTests = new HashSet<DataTest>();
            SprEmployeesJobPosCombinations = new HashSet<SprEmployeesJobPosCombination>();
            SprEmployeesJobPosFines = new HashSet<SprEmployeesJobPosFine>();
            SprEmployeesJobPosSalaries = new HashSet<SprEmployeesJobPosSalary>();
            SprEmployeesMfcJoins = new HashSet<SprEmployeesMfcJoin>();
            SprEmployeesSalaries = new HashSet<SprEmployeesSalary>();
            SprTestQuestionJobPos = new HashSet<SprTestQuestionJobPo>();
        }

        public string JobPosName { get; set; }
        public string Commentt { get; set; }
        public int Id { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public short? Sorting { get; set; }

        public virtual ICollection<ArchivePremium> ArchivePremia { get; set; }
        public virtual ICollection<ArchivePremiumStep> ArchivePremiumSteps { get; set; }
        public virtual ICollection<ArchiveService> ArchiveServiceSprEmployeesJobPos { get; set; }
        public virtual ICollection<ArchiveService> ArchiveServiceSprEmployeesJobPosIdExecutionNavigations { get; set; }
        public virtual ICollection<ArchiveServicesFileResult> ArchiveServicesFileResults { get; set; }
        public virtual ICollection<ArchiveServicesRoutesStage> ArchiveServicesRoutesStages { get; set; }
        public virtual ICollection<DataPremiumFine> DataPremiumFines { get; set; }
        public virtual ICollection<DataPremiumStep> DataPremiumSteps { get; set; }
        public virtual ICollection<DataService> DataServiceSprEmployeesJobPos { get; set; }
        public virtual ICollection<DataService> DataServiceSprEmployeesJobPosIdExecutionNavigations { get; set; }
        public virtual ICollection<DataServicesFileResult> DataServicesFileResults { get; set; }
        public virtual ICollection<DataServicesRoutesStage> DataServicesRoutesStages { get; set; }
        public virtual ICollection<DataTestQuestionEmployee> DataTestQuestionEmployees { get; set; }
        public virtual ICollection<DataTest> DataTests { get; set; }
        public virtual ICollection<SprEmployeesJobPosCombination> SprEmployeesJobPosCombinations { get; set; }
        public virtual ICollection<SprEmployeesJobPosFine> SprEmployeesJobPosFines { get; set; }
        public virtual ICollection<SprEmployeesJobPosSalary> SprEmployeesJobPosSalaries { get; set; }
        public virtual ICollection<SprEmployeesMfcJoin> SprEmployeesMfcJoins { get; set; }
        public virtual ICollection<SprEmployeesSalary> SprEmployeesSalaries { get; set; }
        public virtual ICollection<SprTestQuestionJobPo> SprTestQuestionJobPos { get; set; }
    }
}
