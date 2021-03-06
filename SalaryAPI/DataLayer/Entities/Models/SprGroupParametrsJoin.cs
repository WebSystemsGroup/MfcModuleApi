using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprGroupParametrsJoin
    {
        public int Id { get; set; }
        public int SprGroupParametrsId { get; set; }
        public int SprParametrsId { get; set; }
        public int? RowDel { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }

        public virtual SprGroupParametr SprGroupParametrs { get; set; }
        public virtual SprParametr1 SprParametrs { get; set; }
    }
}
