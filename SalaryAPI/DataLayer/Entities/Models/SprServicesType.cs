using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesType
    {
        public SprServicesType()
        {
            SprServices = new HashSet<SprService>();
        }

        public Guid Id { get; set; }
        public string TypeName { get; set; }
        public string Commentt { get; set; }
        public DateTime? SetDate { get; set; }
        public string SetEmployeesFio { get; set; }

        public virtual ICollection<SprService> SprServices { get; set; }
    }
}
