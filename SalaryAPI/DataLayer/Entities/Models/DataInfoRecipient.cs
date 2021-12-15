using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataInfoRecipient
    {
        public Guid Id { get; set; }
        public Guid DataInfoId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public string EmployeesFio { get; set; }
        public string EmployeesMfcName { get; set; }
        public string EmployeesJobPosName { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioModify { get; set; }
        public string IpAddressAdd { get; set; }
        public DateTime? DateSing { get; set; }

        public virtual DataInfo DataInfo { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
    }
}
