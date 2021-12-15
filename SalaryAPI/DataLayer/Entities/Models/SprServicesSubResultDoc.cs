using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSubResultDoc
    {
        public Guid SprDocumentsId { get; set; }
        public bool DocumentResult { get; set; }
        public string DocumentMethod { get; set; }
        public string DocumentPeriodProvider { get; set; }
        public string DocumentPeriodMfc { get; set; }
        public string Commentt { get; set; }
        public Guid Id { get; set; }
        public Guid SprServicesSubId { get; set; }
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

        public virtual SprDocument SprDocuments { get; set; }
        public virtual SprServicesSub SprServicesSub { get; set; }
    }
}
