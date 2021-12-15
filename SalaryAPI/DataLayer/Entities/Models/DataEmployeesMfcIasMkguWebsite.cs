using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataEmployeesMfcIasMkguWebsite
    {
        public Guid Id { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public decimal IasMkguRating { get; set; }
        public DateTime DateRating { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }

        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
    }
}
