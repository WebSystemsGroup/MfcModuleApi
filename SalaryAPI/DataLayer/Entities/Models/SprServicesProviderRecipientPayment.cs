using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesProviderRecipientPayment
    {
        public Guid Id { get; set; }
        public Guid SprServicesProviderId { get; set; }
        public Guid? SprEmployeesMfcId { get; set; }
        public string ServicesProviderInn { get; set; }
        public string ServicesProviderKpp { get; set; }
        public string ServicesProviderOktmo { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public string ServicesProviderBik { get; set; }
        public string ServicesProviderRs { get; set; }
        public string ServicesProviderBankName { get; set; }
        public string ServicesProviderKs { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }
        public string Purpose { get; set; }

        public virtual SprServicesProvider SprServicesProvider { get; set; }
    }
}
