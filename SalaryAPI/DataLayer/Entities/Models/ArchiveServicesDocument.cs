using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchiveServicesDocument
    {
        public Guid Id { get; set; }
        public string ArchiveServicesInfoId { get; set; }
        public Guid SprDocumentsId { get; set; }
        public short DocumentCount { get; set; }
        public string Commentt { get; set; }
        public Guid ArchiveServicesId { get; set; }
        public short DocumentType { get; set; }
        public short DocumentNeeds { get; set; }
        public bool Check { get; set; }

        public virtual ArchiveService ArchiveServices { get; set; }
        public virtual ArchiveServicesInfo ArchiveServicesInfo { get; set; }
        public virtual SprDocument SprDocuments { get; set; }
    }
}
