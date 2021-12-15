using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprForm
    {
        public SprForm()
        {
            SprServicesForms = new HashSet<SprServicesForm>();
        }

        public int Id { get; set; }
        public string FormsName { get; set; }
        public string Commentt { get; set; }

        public virtual ICollection<SprServicesForm> SprServicesForms { get; set; }
    }
}
