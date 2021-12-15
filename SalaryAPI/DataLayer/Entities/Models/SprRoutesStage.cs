using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprRoutesStage
    {
        public SprRoutesStage()
        {
            ArchivePremiumFineSums = new HashSet<ArchivePremiumFineSum>();
            ArchiveServicesRoutesStages = new HashSet<ArchiveServicesRoutesStage>();
            DataPremiumFines = new HashSet<DataPremiumFine>();
            DataReportOverdueRoutesStages = new HashSet<DataReportOverdueRoutesStage>();
            DataServicesRoutesStages = new HashSet<DataServicesRoutesStage>();
            SprRoutesStageNextSprRoutesStageNextNavigations = new HashSet<SprRoutesStageNext>();
            SprRoutesStageNextSprRoutesStages = new HashSet<SprRoutesStageNext>();
            SprRoutesStageRoleJoinSprEmployeesRoles = new HashSet<SprRoutesStageRoleJoin>();
            SprRoutesStageRoleJoinSprRoutesStages = new HashSet<SprRoutesStageRoleJoin>();
            SprServicesSubStatusJoins = new HashSet<SprServicesSubStatusJoin>();
        }

        public int Id { get; set; }
        public string StageName { get; set; }
        public string Commentt { get; set; }
        public DateTime SetDate { get; set; }
        public short CountDayExecution { get; set; }
        public short? RecordNumber { get; set; }

        public virtual ICollection<ArchivePremiumFineSum> ArchivePremiumFineSums { get; set; }
        public virtual ICollection<ArchiveServicesRoutesStage> ArchiveServicesRoutesStages { get; set; }
        public virtual ICollection<DataPremiumFine> DataPremiumFines { get; set; }
        public virtual ICollection<DataReportOverdueRoutesStage> DataReportOverdueRoutesStages { get; set; }
        public virtual ICollection<DataServicesRoutesStage> DataServicesRoutesStages { get; set; }
        public virtual ICollection<SprRoutesStageNext> SprRoutesStageNextSprRoutesStageNextNavigations { get; set; }
        public virtual ICollection<SprRoutesStageNext> SprRoutesStageNextSprRoutesStages { get; set; }
        public virtual ICollection<SprRoutesStageRoleJoin> SprRoutesStageRoleJoinSprEmployeesRoles { get; set; }
        public virtual ICollection<SprRoutesStageRoleJoin> SprRoutesStageRoleJoinSprRoutesStages { get; set; }
        public virtual ICollection<SprServicesSubStatusJoin> SprServicesSubStatusJoins { get; set; }
    }
}
