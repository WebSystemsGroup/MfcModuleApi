using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataServicesSmevRequestStatus
    {
        public Guid Id { get; set; }
        public Guid DataServicesSmevRequestId { get; set; }
        public string MessageId { get; set; }
        public string RequestIdRef { get; set; }
        public DateTime? DateRequest { get; set; }
        public TimeSpan? TimeRequest { get; set; }

        public virtual DataServicesSmevRequest DataServicesSmevRequest { get; set; }
    }
}
