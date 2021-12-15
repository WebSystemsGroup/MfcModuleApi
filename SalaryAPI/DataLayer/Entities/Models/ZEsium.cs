using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ZEsium
    {
        public string Fio { get; set; }
        public string SerialNumber { get; set; }
        public string Code { get; set; }
        public string Snils { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string BirthPlace { get; set; }
        public string DocIssuer { get; set; }
        public DateTime? DocDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public Guid Id { get; set; }
        public string Gender { get; set; }
    }
}
