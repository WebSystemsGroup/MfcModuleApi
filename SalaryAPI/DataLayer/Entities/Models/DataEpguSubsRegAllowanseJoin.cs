using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataEpguSubsRegAllowanseJoin
    {
        public string Region { get; set; }
        public Guid Id { get; set; }
        public Guid DataEpguSubsRegAllowanseDocumentId { get; set; }
        public Guid DataEpguSubsRegCategoryCopyrightId { get; set; }
    }
}
