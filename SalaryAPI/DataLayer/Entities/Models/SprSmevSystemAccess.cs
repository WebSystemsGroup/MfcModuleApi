using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprSmevSystemAccess
    {
        public SprSmevSystemAccess()
        {
            DataEpguDocumentsLoads = new HashSet<DataEpguDocumentsLoad>();
            DataEpguDocumentsResponses = new HashSet<DataEpguDocumentsResponse>();
        }

        public Guid Id { get; set; }
        public string SmevName { get; set; }
        public string SmevMnemonic { get; set; }
        public bool TestAccess { get; set; }
        public bool ProductionAccess { get; set; }
        public byte[] Certificate { get; set; }

        public virtual ICollection<DataEpguDocumentsLoad> DataEpguDocumentsLoads { get; set; }
        public virtual ICollection<DataEpguDocumentsResponse> DataEpguDocumentsResponses { get; set; }
    }
}
