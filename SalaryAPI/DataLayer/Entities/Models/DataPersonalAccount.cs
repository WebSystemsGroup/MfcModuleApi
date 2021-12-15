using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataPersonalAccount
    {
        public Guid Id { get; set; }
        public string CustomerFio { get; set; }
        public string CustomerSnils { get; set; }
        public string CustomerInn { get; set; }
        public string CustomerSex { get; set; }
        public string CustomerTel { get; set; }
        public string CustomerEmail { get; set; }
        public string DocSerial { get; set; }
        public string DocNumber { get; set; }
        public DateTime? DocBirthDate { get; set; }
        public string DocIssueBody { get; set; }
        public DateTime? DocIssueDate { get; set; }
        public string DocCode { get; set; }
        public string DocBirthPlace { get; set; }
    }
}
