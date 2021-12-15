using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataServicesCommenttRecipient
    {
        public Guid Id { get; set; }
        public Guid DataServicesCommenttId { get; set; }
        public Guid SprEmployeesIdRecipient { get; set; }
        public DateTime? DateRead { get; set; }
        public string EmployeesFioRead { get; set; }
        public string EmployeesFio { get; set; }
        public string EmployeesMfcName { get; set; }
        public string EmployeesJobPosName { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }

        public virtual DataServicesCommentt DataServicesCommentt { get; set; }
        public virtual SprEmployee SprEmployeesIdRecipientNavigation { get; set; }
    }
}
