using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class TestFataly
    {
        public Guid Id { get; set; }
        public string Fio { get; set; }
        public DateTime? DateBirth { get; set; }
        public string DocumentType { get; set; }
        public string Serial { get; set; }
        public string Number { get; set; }
        public DateTime? DateDoc { get; set; }
        public string Code { get; set; }
    }
}
