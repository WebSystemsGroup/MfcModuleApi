using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataNewsRecipient
    {
        public Guid Id { get; set; }
        public Guid DataNewsId { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }

        public virtual DataNews DataNews { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
    }
}
