using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataElkOrder
    {
        public Guid Id { get; set; }
        public int? AisOrderId { get; set; }
        public Guid DataServicesId { get; set; }
        public string Eservicecode { get; set; }
        public string Servicetargetcode { get; set; }
        public string Usertype { get; set; }
        public string Snils { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Ogrn { get; set; }
        public string ServiceOkato { get; set; }
        public string Description { get; set; }
        public string OrderComment { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateSent { get; set; }
        public long? Orderid { get; set; }
        public string Responsecode { get; set; }
        public string ResponsecodeDescription { get; set; }
        public byte[] RequestXml { get; set; }
        public byte[] ResponseXml { get; set; }
        public string RequestIdRef { get; set; }
        public string MessageId { get; set; }
    }
}
