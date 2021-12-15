using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataServicesViewLog
    {
        public Guid Id { get; set; }
        public Guid SprEmployeesId { get; set; }
        public string EmployeesJobPosName { get; set; }
        public string EmployeesFio { get; set; }
        public DateTime SetDate { get; set; }
        public string DataServicesInfoId { get; set; }
        public string EmployeesMfcName { get; set; }

        public virtual DataServicesInfo DataServicesInfo { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
    }
}
