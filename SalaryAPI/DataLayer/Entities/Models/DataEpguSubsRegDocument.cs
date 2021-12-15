using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataEpguSubsRegDocument
    {
        public string Region { get; set; }
        public Guid Id { get; set; }
        public string DocumentName { get; set; }
        public string Commentt { get; set; }
    }
}
