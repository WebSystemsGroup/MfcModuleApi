using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprDocumentIdentity
    {
        public int Id { get; set; }
        public string DocumentName { get; set; }
        public string Commentt { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public string DocumentNameSmall { get; set; }
    }
}
