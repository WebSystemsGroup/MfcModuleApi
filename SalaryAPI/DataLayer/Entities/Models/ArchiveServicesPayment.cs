using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchiveServicesPayment
    {
        public Guid Id { get; set; }
        public Guid ArchiveServicesId { get; set; }
        public Guid? SprEmployeesMfcId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public int? PaymentNumber { get; set; }
        public DateTime? PaymentDateEnter { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerMiddleName { get; set; }
        public string DocumentCode { get; set; }
        public string DocumentSerial { get; set; }
        public string DocumentNumber { get; set; }
        public string PaymentKbk { get; set; }
        public string PaymentOktmo { get; set; }
        public string PaymentInn { get; set; }
        public string PaymentKpp { get; set; }
        public string PaymentPurpose { get; set; }
        public string PaymentRecipient { get; set; }
        public decimal? PaymentValue { get; set; }
        public string PaymentOsmpId { get; set; }
        public int? PaymentPrvTxn { get; set; }
        public short PaymentAgent { get; set; }
        public bool? PaymentSign { get; set; }
        public string PaymentAddress { get; set; }
        public string PaymentBik { get; set; }
        public string PaymentRs { get; set; }
        public string PaymentBankName { get; set; }
        public string PaymentKs { get; set; }
        public Guid ArchiveServicesCustomerId { get; set; }
        public string DocumentInfo { get; set; }
        public string CustomerTel { get; set; }
        public string Uin { get; set; }
        public string ArchiveServicesInfoId { get; set; }
        public string CustomerName { get; set; }
        public string CodeCheckmaster { get; set; }
        public string CustomerSnils { get; set; }
        public string CustomerInn { get; set; }
        public Guid? PaymentIdParent { get; set; }
        public string PersonalAccount { get; set; }

        public virtual ArchiveService ArchiveServices { get; set; }
        public virtual ArchiveServicesCustomer ArchiveServicesCustomer { get; set; }
        public virtual ArchiveServicesInfo ArchiveServicesInfo { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
    }
}
