using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprMdmObjectType
    {
        public SprMdmObjectType()
        {
            DataMdmObjectsUploads = new HashSet<DataMdmObjectsUpload>();
            SprMdmObjectAttributes = new HashSet<SprMdmObjectAttribute>();
        }

        public int Id { get; set; }
        public string ObjectTypeMnemo { get; set; }
        public string ObjectTypeName { get; set; }

        public virtual ICollection<DataMdmObjectsUpload> DataMdmObjectsUploads { get; set; }
        public virtual ICollection<SprMdmObjectAttribute> SprMdmObjectAttributes { get; set; }
    }
}
