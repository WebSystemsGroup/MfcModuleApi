using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataServicesCommentt
    {
        public DataServicesCommentt()
        {
            DataServicesCommenttRecipients = new HashSet<DataServicesCommenttRecipient>();
        }

        public Guid Id { get; set; }
        public Guid DataServicesId { get; set; }
        public string DataServicesInfoId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public string Commentt { get; set; }
        public DateTime DateEnter { get; set; }
        public string EmployeesFio { get; set; }
        public string EmployeesMfcName { get; set; }
        public string EmployeesJobPosName { get; set; }
        public bool? PublicCommentt { get; set; }
        public int? SprEmployeesJobPosId { get; set; }
        public Guid? SprEmployeesMfcId { get; set; }
        public bool? Personal { get; set; }
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
        public virtual SprEmployee SprEmployees { get; set; }
        public virtual ICollection<DataServicesCommenttRecipient> DataServicesCommenttRecipients { get; set; }
    }
}
