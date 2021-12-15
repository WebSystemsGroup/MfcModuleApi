using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataMdmObjectsUploadV2
    {
        public DataMdmObjectsUploadV2()
        {
            DataMdmObjectsAttributesUploadV2s = new HashSet<DataMdmObjectsAttributesUploadV2>();
        }

        public long Id { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public int SprMdmObjectTypeV2Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool ObjectIsSent { get; set; }
        public DateTime? SentDate { get; set; }
        public string MessageId { get; set; }
        public bool ObjectInvalid { get; set; }
        public Guid? DataServicesId { get; set; }

        public virtual SprMdmObjectTypeV2 SprMdmObjectTypeV2 { get; set; }
        public virtual ICollection<DataMdmObjectsAttributesUploadV2> DataMdmObjectsAttributesUploadV2s { get; set; }
    }
}
