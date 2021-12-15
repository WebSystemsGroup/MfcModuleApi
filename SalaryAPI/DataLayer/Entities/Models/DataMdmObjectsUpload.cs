using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataMdmObjectsUpload
    {
        public DataMdmObjectsUpload()
        {
            DataMdmObjectsAttributesUploads = new HashSet<DataMdmObjectsAttributesUpload>();
        }

        public long Id { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public int SprMdmObjectTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool ObjectIsSent { get; set; }
        public DateTime? SentDate { get; set; }
        public string MessageId { get; set; }
        public bool ObjectInvalid { get; set; }

        public virtual SprMdmObjectType SprMdmObjectType { get; set; }
        public virtual ICollection<DataMdmObjectsAttributesUpload> DataMdmObjectsAttributesUploads { get; set; }
    }
}
