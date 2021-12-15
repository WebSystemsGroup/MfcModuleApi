using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprSmevClassOszn
    {
        public Guid Id { get; set; }
        public int OsznCode { get; set; }
        public string OsznName { get; set; }
        public string OsznAddress { get; set; }
        public string ServiceCode { get; set; }
    }
}
