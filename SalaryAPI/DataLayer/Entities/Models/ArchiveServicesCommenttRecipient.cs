using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchiveServicesCommenttRecipient
    {
        public Guid Id { get; set; }
        public Guid ArchiveServicesCommenttId { get; set; }
        public Guid SprEmployeesIdRecipient { get; set; }
        public DateTime? DateRead { get; set; }
        public string EmployeesFioRead { get; set; }
        public string EmployeesFio { get; set; }
        public string EmployeesMfcName { get; set; }
        public string EmployeesJobPosName { get; set; }

        public virtual ArchiveServicesCommentt ArchiveServicesCommentt { get; set; }
        public virtual SprEmployee SprEmployeesIdRecipientNavigation { get; set; }
    }
}
