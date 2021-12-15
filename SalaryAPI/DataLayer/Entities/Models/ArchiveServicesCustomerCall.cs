using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchiveServicesCustomerCall
    {
        public Guid Id { get; set; }
        public string ArchiveServicesInfoId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public string EmployeesFio { get; set; }
        public string CustomerName { get; set; }
        public DateTime DateCall { get; set; }
        public string CustomerTel { get; set; }
        public string TimeTalk { get; set; }
        public Guid ArchiveServicesId { get; set; }
        public Guid SprEmployeesMfcFtpId { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public string SoundFormat { get; set; }
        public bool? SaveFtp { get; set; }
        public string EmployeesMfcName { get; set; }
        public string EmployeesJobPosName { get; set; }
        public int? SprEmployeesJobPosId { get; set; }
        public int? TypeCall { get; set; }

        public virtual ArchiveService ArchiveServices { get; set; }
        public virtual ArchiveServicesInfo ArchiveServicesInfo { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual SprEmployeesMfcFtp SprEmployeesMfcFtp { get; set; }
    }
}
