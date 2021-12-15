using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataMdmObjectsAttributesUpload
    {
        public long Id { get; set; }
        public long DataMdmObjectsUploadId { get; set; }
        public int SprMdmObjectAttributeId { get; set; }
        public string MdmAttributeValue { get; set; }

        public virtual DataMdmObjectsUpload DataMdmObjectsUpload { get; set; }
        public virtual SprMdmObjectAttribute SprMdmObjectAttribute { get; set; }
    }
}
