using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchiveCoverLetter
    {
        public Guid Id { get; set; }
        public Guid ArchiveServicesId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public string EmployeeFio { get; set; }
        public string NumberCoverLetter { get; set; }
        public DateTime DateAdd { get; set; }
        public string JsonData { get; set; }

        public virtual ArchiveService ArchiveServices { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
    }
}
