using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataIasMkguRatingLogLoad
    {
        public Guid Id { get; set; }
        public string FrguProviderId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string MessageId { get; set; }
        public byte[] RequestXml { get; set; }
        public byte[] ResponseXml { get; set; }
    }
}
