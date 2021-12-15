using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchiveServicesCommentt
    {
        public ArchiveServicesCommentt()
        {
            ArchiveServicesCommenttRecipients = new HashSet<ArchiveServicesCommenttRecipient>();
        }

        public Guid Id { get; set; }
        public Guid ArchiveServicesId { get; set; }
        public string ArchiveServicesInfoId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public string Commentt { get; set; }
        public DateTime DateEnter { get; set; }
        public string EmployeesFio { get; set; }
        public string EmployeesMfcName { get; set; }
        public string EmployeesJobPosName { get; set; }
        public bool? PublicCommentt { get; set; }
        public Guid? SprEmployeesMfcId { get; set; }
        public int? SprEmployeesJobPosId { get; set; }
        public bool? Personal { get; set; }

        public virtual ArchiveService ArchiveServices { get; set; }
        public virtual ArchiveServicesInfo ArchiveServicesInfo { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
        public virtual ICollection<ArchiveServicesCommenttRecipient> ArchiveServicesCommenttRecipients { get; set; }
    }
}
