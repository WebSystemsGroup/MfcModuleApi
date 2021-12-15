using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataNewsView
    {
        public Guid Id { get; set; }
        public Guid DataNewsId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public string EmployeesFio { get; set; }
        public DateTime DateView { get; set; }
        public string EmployeesMfcName { get; set; }
        public string EmployeesJobPosName { get; set; }

        public virtual DataNews DataNews { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
    }
}
