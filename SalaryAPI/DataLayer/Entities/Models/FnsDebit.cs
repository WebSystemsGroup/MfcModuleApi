using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class FnsDebit
    {
        public Guid Id { get; set; }
        public string Inn { get; set; }
        public string PayerName { get; set; }
        public string Address { get; set; }
        public decimal? DebitValue { get; set; }
        public string TaxName { get; set; }
    }
}
