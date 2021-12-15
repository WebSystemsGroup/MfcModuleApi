using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataMdmObjectsLogUpload
    {
        public Guid Id { get; set; }
        public string MessageId { get; set; }
        public byte[] RequestXml { get; set; }
        public byte[] ResponseXml { get; set; }
    }
}
