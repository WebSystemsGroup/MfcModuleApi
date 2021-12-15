using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSubTypeQuality
    {
        public SprServicesSubTypeQuality()
        {
            SprServicesSubTypeQualityJoins = new HashSet<SprServicesSubTypeQualityJoin>();
        }

        public string TypeName { get; set; }
        public string Commentt { get; set; }
        public short Id { get; set; }

        public virtual ICollection<SprServicesSubTypeQualityJoin> SprServicesSubTypeQualityJoins { get; set; }
    }
}
