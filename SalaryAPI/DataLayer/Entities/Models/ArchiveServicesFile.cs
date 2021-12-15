using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchiveServicesFile
    {
        public Guid Id { get; set; }
        public Guid ArchiveServicesTableId { get; set; }
        public Guid SprEmployeesMfcFtpId { get; set; }
        public DateTime DateEnter { get; set; }
        public string FileName { get; set; }
        public string FileExt { get; set; }
        public int FileSize { get; set; }
        public string EmployeesFio { get; set; }
        public string Commentt { get; set; }
        public string ArchiveServicesInfoId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public short? FileFlag { get; set; }
        public string EmployeesMfcName { get; set; }
        public string EmployeesJobPosName { get; set; }
        public Guid? SprEmployeesMfcId { get; set; }
        public int? SprEmployeesJobPosId { get; set; }
        public short? TypeAddFile { get; set; }
        public bool? IsPaid { get; set; }

        public virtual ArchiveServicesInfo ArchiveServicesInfo { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprEmployeesMfcFtp SprEmployeesMfcFtp { get; set; }
    }
}
