using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprDocumentCode
    {
        public string DocumentCode { get; set; }
        public string DocumentIssueBody { get; set; }
        public Guid Id { get; set; }
        public DateTime? DateStop { get; set; }
    }
}
