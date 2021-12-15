using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSubCustomer
    {
        public SprServicesSubCustomer()
        {
            SprServicesSubDocumentCustomers = new HashSet<SprServicesSubDocumentCustomer>();
            SprServicesSubTariffs = new HashSet<SprServicesSubTariff>();
        }

        public Guid Id { get; set; }
        public Guid SprServicesSubId { get; set; }
        public int SprServicesSubTypeRecipientId { get; set; }
        public string RepresentativeList { get; set; }
        public string RepresentativeDocument { get; set; }
        public string RepresentativeSpecification { get; set; }
        public string SetEmployeesFio { get; set; }
        public DateTime SetDate { get; set; }
        public bool? Representative { get; set; }
        public string Commentt { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }

        public virtual SprServicesSub SprServicesSub { get; set; }
        public virtual SprServicesSubTypeRecipient SprServicesSubTypeRecipient { get; set; }
        public virtual ICollection<SprServicesSubDocumentCustomer> SprServicesSubDocumentCustomers { get; set; }
        public virtual ICollection<SprServicesSubTariff> SprServicesSubTariffs { get; set; }
    }
}
