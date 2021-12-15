using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchiveServicesCustomerMessage
    {
        public Guid Id { get; set; }
        public string ArchiveServicesInfoId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public string EmployeesFio { get; set; }
        public string CustomerName { get; set; }
        public DateTime DateMessage { get; set; }
        public string CustomerTel { get; set; }
        public Guid ArchiveServicesId { get; set; }
        public string TextMessage { get; set; }
        public string EmployeesMfcName { get; set; }
        public string EmployeesJobPosName { get; set; }
        public Guid? SprEmployeesMfcId { get; set; }
        public int? SprEmployeesJobPosId { get; set; }

        public virtual ArchiveService ArchiveServices { get; set; }
        public virtual ArchiveServicesInfo ArchiveServicesInfo { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
    }
}
