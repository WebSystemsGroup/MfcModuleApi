using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataEpguSubsRegDocumentJoin
    {
        public Guid Id { get; set; }
        public string Region { get; set; }
        public string DataEpguSubsRegOptionsServiceId { get; set; }
        public int? CustomerType { get; set; }
        public Guid? DataEpguSubsRegDocumentId { get; set; }
    }
}
