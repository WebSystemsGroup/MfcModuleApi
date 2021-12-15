using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSubTypeQualityJoin
    {
        public Guid Id { get; set; }
        public Guid SprServicesSubId { get; set; }
        public string SetEmployeesFio { get; set; }
        public DateTime SetDate { get; set; }
        public short SprServicesSubTypeQualityId { get; set; }

        public virtual SprServicesSub SprServicesSub { get; set; }
        public virtual SprServicesSubTypeQuality SprServicesSubTypeQuality { get; set; }
    }
}
