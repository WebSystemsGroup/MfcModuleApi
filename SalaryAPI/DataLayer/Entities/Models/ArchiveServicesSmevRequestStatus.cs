using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchiveServicesSmevRequestStatus
    {
        public Guid Id { get; set; }
        public Guid ArchiveServicesSmevRequestId { get; set; }
        public string MessageId { get; set; }
        public string RequestIdRef { get; set; }
        public DateTime? DateRequest { get; set; }
        public TimeSpan? TimeRequest { get; set; }

        public virtual ArchiveServicesSmevRequest ArchiveServicesSmevRequest { get; set; }
    }
}
