using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataMdmObjectsAttributesUploadV2
    {
        public long Id { get; set; }
        public long DataMdmObjectsUploadV2Id { get; set; }
        public int SprMdmObjectAttributeV2Id { get; set; }
        public string MdmAttributeValue { get; set; }
        public Guid? DataServicesId { get; set; }

        public virtual DataMdmObjectsUploadV2 DataMdmObjectsUploadV2 { get; set; }
        public virtual SprMdmObjectAttributeV2 SprMdmObjectAttributeV2 { get; set; }
    }
}
