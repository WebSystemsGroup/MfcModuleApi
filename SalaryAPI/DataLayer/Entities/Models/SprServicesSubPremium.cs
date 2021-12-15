using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSubPremium
    {
        public Guid Id { get; set; }
        public Guid SprServicesSubId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateStop { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public decimal ProcessingPremium { get; set; }
        public decimal ServiceAdd { get; set; }
        public decimal CustomerAdd { get; set; }
        public decimal DocumentScan { get; set; }
        public decimal ServiceConsultation { get; set; }
        public decimal ServiceExecuted { get; set; }
        public decimal CallCustomer { get; set; }
        public decimal SmsCustomer { get; set; }
        public decimal CommenttAdd { get; set; }
        public decimal IasMkguAdd { get; set; }
        public decimal FormsAdd { get; set; }
        public decimal PkpvdAdd { get; set; }
        public decimal SmevExecution { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }

        public virtual SprServicesSub SprServicesSub { get; set; }
    }
}
