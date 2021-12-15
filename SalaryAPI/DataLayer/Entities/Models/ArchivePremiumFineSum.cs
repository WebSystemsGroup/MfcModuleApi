using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchivePremiumFineSum
    {
        public Guid Id { get; set; }
        public Guid ArchivePremiumId { get; set; }
        public decimal FinePercent { get; set; }
        public decimal FineSum { get; set; }
        public Guid SprServicesSubId { get; set; }
        public string DataServicesInfoId { get; set; }
        public string ServiceName { get; set; }
        public int SprRoutesStageId { get; set; }
        public string StageName { get; set; }
        public DateTime? DateFine { get; set; }
        public string EmployeesFio { get; set; }
        public string EmployeesJobPosName { get; set; }
        public short? RowDel { get; set; }
        public string EmployeesFioDel { get; set; }
        public string CommenttDel { get; set; }
        public DateTime? DateDel { get; set; }

        public virtual ArchivePremium ArchivePremium { get; set; }
        public virtual SprRoutesStage SprRoutesStage { get; set; }
        public virtual SprServicesSub SprServicesSub { get; set; }
    }
}
