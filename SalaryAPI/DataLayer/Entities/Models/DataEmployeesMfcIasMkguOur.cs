using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataEmployeesMfcIasMkguOur
    {
        public Guid Id { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public decimal IasMkguPercent { get; set; }
        public DateTime DatePercent { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }

        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
    }
}
