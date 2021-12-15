using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprGroupParametr
    {
        public SprGroupParametr()
        {
            SprGroupParametrsJoins = new HashSet<SprGroupParametrsJoin>();
            SprServicesSubGroupParametrsJoins = new HashSet<SprServicesSubGroupParametrsJoin>();
        }

        public int Id { get; set; }
        public string GroupName { get; set; }
        public int? SortField { get; set; }
        public int? RowDel { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public string ParametrMask { get; set; }

        public virtual ICollection<SprGroupParametrsJoin> SprGroupParametrsJoins { get; set; }
        public virtual ICollection<SprServicesSubGroupParametrsJoin> SprServicesSubGroupParametrsJoins { get; set; }
    }
}
