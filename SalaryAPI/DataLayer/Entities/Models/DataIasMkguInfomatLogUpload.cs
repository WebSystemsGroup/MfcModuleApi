using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataIasMkguInfomatLogUpload
    {
        public Guid Id { get; set; }
        public DateTime? DateSend { get; set; }
        public string PackedId { get; set; }
        public byte[] RequestXml { get; set; }
        public byte[] ResponseXml { get; set; }
        public string MessageId { get; set; }
    }
}
