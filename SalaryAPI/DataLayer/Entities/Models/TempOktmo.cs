using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class TempOktmo
    {
        public Guid Id { get; set; }
        public string Municipality { get; set; }
        public string Oktmo { get; set; }
    }
}
