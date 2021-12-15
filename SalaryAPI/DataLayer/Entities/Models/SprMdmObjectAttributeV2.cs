using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprMdmObjectAttributeV2
    {
        public SprMdmObjectAttributeV2()
        {
            DataMdmObjectsAttributesUploadV2s = new HashSet<DataMdmObjectsAttributesUploadV2>();
        }

        public int Id { get; set; }
        public int SprMdmObjectTypeV2Id { get; set; }
        public string ObjectAttributeMnemo { get; set; }
        public string ObjectAttributeName { get; set; }
        public string ObjectAttributeRegex { get; set; }
        public bool IsObjectUuid { get; set; }

        public virtual SprMdmObjectTypeV2 SprMdmObjectTypeV2 { get; set; }
        public virtual ICollection<DataMdmObjectsAttributesUploadV2> DataMdmObjectsAttributesUploadV2s { get; set; }
    }
}
