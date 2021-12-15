using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesForm
    {
        public Guid Id { get; set; }
        public Guid SprServicesSubId { get; set; }
        public int SprFormsId { get; set; }
        public DateTime SetDate { get; set; }
        public short? RowDel { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }

        public virtual SprForm SprForms { get; set; }
        public virtual SprServicesSub SprServicesSub { get; set; }
    }
}
