using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchiveServicesElplat
    {
        public Guid Id { get; set; }
        public string DataServicesInfoId { get; set; }
        public int PaymentId { get; set; }
        public Guid UserId { get; set; }
        public Guid PayerId { get; set; }
        public string PaymentInstrumentCode { get; set; }
        public string InteractionTypeCode { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public decimal Fee { get; set; }
        public int CurrencyCode { get; set; }
        public string HashCode { get; set; }
        public string Fio { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string TransactionId { get; set; }
        public int? Type { get; set; }
        public Guid? Service { get; set; }
        public string Address { get; set; }
        public string Ground { get; set; }
        public string Inn { get; set; }
        public string Rs { get; set; }
        public string Bik { get; set; }
        public string Receiver { get; set; }
        public string Kpp { get; set; }
        public string Kbk { get; set; }
        public string Okato { get; set; }
        public string TaxDocnum { get; set; }
        public string Uin { get; set; }
        public string SprServicesSubName { get; set; }
        public Guid? ArchiveServicesId { get; set; }
    }
}
