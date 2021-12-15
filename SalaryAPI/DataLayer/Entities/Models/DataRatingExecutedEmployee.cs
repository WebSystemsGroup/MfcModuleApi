using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataRatingExecutedEmployee
    {
        public Guid Id { get; set; }
        public Guid SprEmployeesId { get; set; }
        public int Rating { get; set; }
        public int Position { get; set; }
        public string EmployeesFio { get; set; }
        public string EmployeesMfcName { get; set; }
        public string EmployeesJobPosName { get; set; }
        public int PositionMoving { get; set; }
        public string EmployeesLogin { get; set; }

        public virtual SprEmployee SprEmployees { get; set; }
    }
}
