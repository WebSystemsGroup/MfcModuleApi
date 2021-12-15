using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprMdmObjectTypeV2
    {
        public SprMdmObjectTypeV2()
        {
            DataMdmObjectsUploadV2s = new HashSet<DataMdmObjectsUploadV2>();
            SprMdmObjectAttributeV2s = new HashSet<SprMdmObjectAttributeV2>();
        }

        public int Id { get; set; }
        public string ObjectTypeMnemo { get; set; }
        public string ObjectTypeName { get; set; }

        public virtual ICollection<DataMdmObjectsUploadV2> DataMdmObjectsUploadV2s { get; set; }
        public virtual ICollection<SprMdmObjectAttributeV2> SprMdmObjectAttributeV2s { get; set; }
    }
}
