using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchivePremiumFine
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
    }
}
