using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprMinobrCamp
    {
        public Guid Id { get; set; }
        public string CampName { get; set; }
        public bool Shift1 { get; set; }
        public bool Shift2 { get; set; }
        public bool Shift3 { get; set; }
        public string CampId { get; set; }
    }
}
