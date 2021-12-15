using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataReestr
    {
        public DataReestr()
        {
            DataServicesReestrs = new HashSet<DataServicesReestr>();
        }

        public Guid Id { get; set; }
        public int? ReestrNumber { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? ServicesCount { get; set; }
        public string EmployeesFio { get; set; }
        public string EmployeesJobPosName { get; set; }
        public Guid? SprEmployeeId { get; set; }
        public Guid? SprEmployeesMfcId { get; set; }
        public string SprEmployeesMfcName { get; set; }

        public virtual ICollection<DataServicesReestr> DataServicesReestrs { get; set; }
    }
}
