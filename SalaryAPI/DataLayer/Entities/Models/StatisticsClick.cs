using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class StatisticsClick
    {
        public Guid Id { get; set; }
        public int TypeClick { get; set; }
        public DateTime DateClick { get; set; }
        public Guid SprEmployeesId { get; set; }
        public Guid SprEmployeesMfcId { get; set; }

        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
    }
}
