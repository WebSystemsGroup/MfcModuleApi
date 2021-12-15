using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprParametr1
    {
        public SprParametr1()
        {
            SprGroupParametrsJoins = new HashSet<SprGroupParametrsJoin>();
        }

        public int Id { get; set; }
        public string ParametrName { get; set; }
        public int ParametrType { get; set; }
        public string ParametrMark { get; set; }
        public string ParametrMask { get; set; }
        public int? RowDel { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public string DdListParametrValues { get; set; }
        public string JsonValues { get; set; }

        public virtual ICollection<SprGroupParametrsJoin> SprGroupParametrsJoins { get; set; }
    }
}
