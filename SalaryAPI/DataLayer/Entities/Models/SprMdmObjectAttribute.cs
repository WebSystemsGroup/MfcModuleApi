using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprMdmObjectAttribute
    {
        public SprMdmObjectAttribute()
        {
            DataMdmObjectsAttributesUploads = new HashSet<DataMdmObjectsAttributesUpload>();
        }

        public int Id { get; set; }
        public int SprMdmObjectTypeId { get; set; }
        public string ObjectAttributeMnemo { get; set; }
        public string ObjectAttributeName { get; set; }
        public string ObjectAttributeRegex { get; set; }
        public bool IsObjectUuid { get; set; }

        public virtual SprMdmObjectType SprMdmObjectType { get; set; }
        public virtual ICollection<DataMdmObjectsAttributesUpload> DataMdmObjectsAttributesUploads { get; set; }
    }
}
