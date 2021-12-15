using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSubLivingSituation
    {
        public SprServicesSubLivingSituation()
        {
            SprServicesSubLivingSituationsJoins = new HashSet<SprServicesSubLivingSituationsJoin>();
        }

        public Guid Id { get; set; }
        public string SituationName { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }

        public virtual ICollection<SprServicesSubLivingSituationsJoin> SprServicesSubLivingSituationsJoins { get; set; }
    }
}
