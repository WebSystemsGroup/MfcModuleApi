using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchiveForSearch
    {
        public Guid Id { get; set; }
        public string ArchiveServicesInfoId { get; set; }
        public DateTime? DateEnter { get; set; }
        public string StatusName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerTel1 { get; set; }
        public string SprServicesProviderName { get; set; }
        public string SprServicesSubName { get; set; }
        public string EmployeesFio { get; set; }
        public string EmployeesFioExecuted { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public string MfcNameSmall { get; set; }
        public string DocumentSerial { get; set; }
        public string DocumentNumber { get; set; }

        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
    }
}
