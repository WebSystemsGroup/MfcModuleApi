using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSubParametr
    {
        public Guid Id { get; set; }
        public Guid SprServicesSubId { get; set; }
        public int SprParametrId { get; set; }
        public short? RowDel { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }

        public virtual SprParametr SprParametr { get; set; }
        public virtual SprServicesSub SprServicesSub { get; set; }
    }
}
