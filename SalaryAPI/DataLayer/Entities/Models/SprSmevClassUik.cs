using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprSmevClassUik
    {
        public int Id { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string CountryCode { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string UikNumber { get; set; }
    }
}
