using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataEpguSubsRegIncomeDocument
    {
        public string Region { get; set; }
        public Guid Id { get; set; }
        public string DocumentName { get; set; }
    }
}
