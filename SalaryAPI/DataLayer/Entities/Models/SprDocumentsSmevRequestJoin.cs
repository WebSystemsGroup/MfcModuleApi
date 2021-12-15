using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprDocumentsSmevRequestJoin
    {
        public Guid Id { get; set; }
        public Guid SprDocumentsId { get; set; }
        public int SprSmevRequestId { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }

        public virtual SprDocument SprDocuments { get; set; }
        public virtual SprSmevRequest SprSmevRequest { get; set; }
    }
}
