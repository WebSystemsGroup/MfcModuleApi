using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSubWayGetResult
    {
        public SprServicesSubWayGetResult()
        {
            SprServicesSubWayGetResultJoins = new HashSet<SprServicesSubWayGetResultJoin>();
        }

        public Guid Id { get; set; }
        public string NameWay { get; set; }
        public string Commentt { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }

        public virtual ICollection<SprServicesSubWayGetResultJoin> SprServicesSubWayGetResultJoins { get; set; }
    }
}
