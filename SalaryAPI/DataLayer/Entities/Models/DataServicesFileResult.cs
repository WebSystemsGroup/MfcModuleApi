using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataServicesFileResult
    {
        public Guid Id { get; set; }
        public Guid DataServicesId { get; set; }
        public Guid? SprEmployeesMfcFtpId { get; set; }
        public DateTime DateEnter { get; set; }
        public string FileName { get; set; }
        public string FileExt { get; set; }
        public int FileSize { get; set; }
        public string EmployeesFio { get; set; }
        public string Commentt { get; set; }
        public string DataServicesInfoId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public short FileFlag { get; set; }
        public string EmployeesMfcName { get; set; }
        public string EmployeesJobPosName { get; set; }
        public int? SprEmployeesJobPosId { get; set; }
        public Guid? SprEmployeesMfcId { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }

        public virtual DataService DataServices { get; set; }
        public virtual DataServicesInfo DataServicesInfo { get; set; }
        public virtual SprEmployeesJobPo SprEmployeesJobPos { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual SprEmployeesMfcFtp SprEmployeesMfcFtp { get; set; }
    }
}
