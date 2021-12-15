using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprParametr
    {
        public SprParametr()
        {
            ArchiveServicesParametrs = new HashSet<ArchiveServicesParametr>();
            DataServicesParametrs = new HashSet<DataServicesParametr>();
            SprServicesSubParametrs = new HashSet<SprServicesSubParametr>();
        }

        public int Id { get; set; }
        public string ParametrName { get; set; }
        public int ParametrType { get; set; }
        public string Mnemo { get; set; }

        public virtual ICollection<ArchiveServicesParametr> ArchiveServicesParametrs { get; set; }
        public virtual ICollection<DataServicesParametr> DataServicesParametrs { get; set; }
        public virtual ICollection<SprServicesSubParametr> SprServicesSubParametrs { get; set; }
    }
}
