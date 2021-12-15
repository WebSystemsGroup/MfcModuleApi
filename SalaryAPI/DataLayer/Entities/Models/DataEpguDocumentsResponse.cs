using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataEpguDocumentsResponse
    {
        public Guid Id { get; set; }
        public Guid DataEpguDocumentsLoadId { get; set; }
        public DateTime DateCreated { get; set; }
        public int Status { get; set; }
        public Guid? MessageId { get; set; }
        public DateTime? DateResponseRequested { get; set; }
        public DateTime? DateAckConfirmed { get; set; }
        public bool TestMode { get; set; }
        public Guid SprSmevSystemAccessId { get; set; }
        public string StatusComment { get; set; }

        public virtual DataEpguDocumentsLoad DataEpguDocumentsLoad { get; set; }
        public virtual SprSmevSystemAccess SprSmevSystemAccess { get; set; }
    }
}
