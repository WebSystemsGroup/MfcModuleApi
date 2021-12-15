using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSubLivingSituationsJoin
    {
        public Guid Id { get; set; }
        public Guid SprServicesSubId { get; set; }
        public Guid SprServicesSubLivingSituationsId { get; set; }
        public string SetEmployeesFio { get; set; }
        public DateTime SetDate { get; set; }

        public virtual SprServicesSub SprServicesSub { get; set; }
        public virtual SprServicesSubLivingSituation SprServicesSubLivingSituations { get; set; }
    }
}
