using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataInfo
    {
        public DataInfo()
        {
            DataInfoRecipients = new HashSet<DataInfoRecipient>();
            DataInfoViews = new HashSet<DataInfoView>();
        }

        public Guid Id { get; set; }
        public string InfoText { get; set; }
        public DateTime InfoDate { get; set; }
        public string EmployeesFio { get; set; }
        public Guid? SprEmployeesId { get; set; }
        public string InfoTheme { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }
        public string EmployeesJobPosName { get; set; }
        public int DataInfoTypeId { get; set; }

        public virtual DataInfoType DataInfoType { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
        public virtual ICollection<DataInfoRecipient> DataInfoRecipients { get; set; }
        public virtual ICollection<DataInfoView> DataInfoViews { get; set; }
    }
}
