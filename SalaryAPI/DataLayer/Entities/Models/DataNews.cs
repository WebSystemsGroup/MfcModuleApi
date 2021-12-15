using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataNews
    {
        public DataNews()
        {
            DataNewsFiles = new HashSet<DataNewsFile>();
            DataNewsRecipients = new HashSet<DataNewsRecipient>();
            DataNewsViews = new HashSet<DataNewsView>();
        }

        public Guid Id { get; set; }
        public string NewsText { get; set; }
        public DateTime NewsDate { get; set; }
        public string EmployeesFio { get; set; }
        public Guid? SprEmployeesId { get; set; }
        public string NewsTheme { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }
        public string EmployeesJobPosName { get; set; }

        public virtual ICollection<DataNewsFile> DataNewsFiles { get; set; }
        public virtual ICollection<DataNewsRecipient> DataNewsRecipients { get; set; }
        public virtual ICollection<DataNewsView> DataNewsViews { get; set; }
    }
}
