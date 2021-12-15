using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprDocument
    {
        public SprDocument()
        {
            ArchiveServicesDocuments = new HashSet<ArchiveServicesDocument>();
            DataServicesDocuments = new HashSet<DataServicesDocument>();
            SprDocumentsSmevRequestJoins = new HashSet<SprDocumentsSmevRequestJoin>();
            SprServicesSubDocumentCustomers = new HashSet<SprServicesSubDocumentCustomer>();
            SprServicesSubDocuments = new HashSet<SprServicesSubDocument>();
            SprServicesSubResultDocs = new HashSet<SprServicesSubResultDoc>();
        }

        public Guid Id { get; set; }
        public string DocumentName { get; set; }
        public byte[] DocumentSample { get; set; }
        public string DocumentDescription { get; set; }
        public string Commentt { get; set; }
        public string DocumentSpecification { get; set; }
        public string SetEmployeesFio { get; set; }
        public DateTime SetDate { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }

        public virtual ICollection<ArchiveServicesDocument> ArchiveServicesDocuments { get; set; }
        public virtual ICollection<DataServicesDocument> DataServicesDocuments { get; set; }
        public virtual ICollection<SprDocumentsSmevRequestJoin> SprDocumentsSmevRequestJoins { get; set; }
        public virtual ICollection<SprServicesSubDocumentCustomer> SprServicesSubDocumentCustomers { get; set; }
        public virtual ICollection<SprServicesSubDocument> SprServicesSubDocuments { get; set; }
        public virtual ICollection<SprServicesSubResultDoc> SprServicesSubResultDocs { get; set; }
    }
}
