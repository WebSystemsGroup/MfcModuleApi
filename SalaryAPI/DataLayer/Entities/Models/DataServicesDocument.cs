using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataServicesDocument
    {
        public Guid Id { get; set; }
        public string DataServicesInfoId { get; set; }
        public Guid SprDocumentsId { get; set; }
        public short DocumentCount { get; set; }
        public string Commentt { get; set; }
        public Guid DataServicesId { get; set; }
        public short DocumentType { get; set; }
        public short DocumentNeeds { get; set; }
        public bool Check { get; set; }

        public virtual DataService DataServices { get; set; }
        public virtual DataServicesInfo DataServicesInfo { get; set; }
        public virtual SprDocument SprDocuments { get; set; }
    }
}
