using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchivePremiumStepSum
    {
        public Guid Id { get; set; }
        public Guid ArchivePremiumId { get; set; }
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
        public int ProcessingPremiumCount { get; set; }
        public int ServiceAddCount { get; set; }
        public int CustomerAddCount { get; set; }
        public int DocumentScanCount { get; set; }
        public int ServiceConsultationCount { get; set; }
        public int ServiceExecutedCount { get; set; }
        public int CallCustomerCount { get; set; }
        public int SmsCustomerCount { get; set; }
        public int CommenttAddCount { get; set; }
        public int IasMkguAddCount { get; set; }
        public int FormsAddCount { get; set; }
        public int PkpvdAddCount { get; set; }
        public int SmevExecutionCount { get; set; }

        public virtual ArchivePremium ArchivePremium { get; set; }
    }
}
