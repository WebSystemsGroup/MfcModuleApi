using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataPaternityZag
    {
        public Guid Id { get; set; }
        public string ActNumber { get; set; }
        public DateTime? ActDate { get; set; }
        public string ActVersionNumber { get; set; }
        public DateTime? ActVersionDate { get; set; }
        public DateTime? ActStatusDate { get; set; }
        public string ActStatus { get; set; }
        public string SerialDocumentPaternity { get; set; }
        public string NumberDocumentPaternity { get; set; }
        public DateTime? DateDocumentPaternity { get; set; }
        public string Fio { get; set; }
        public string BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string DocumentNameUpdate { get; set; }
        public string DocumentSerialNumberUpdate { get; set; }
        public DateTime? DocumentDateUpdate { get; set; }
        public string DocumentIssuerUpdate { get; set; }
        public string DocumentCode { get; set; }
        public string DocumentSerialNumber { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string DocumentIssuer { get; set; }
        public string NationalityCode { get; set; }
        public string Address { get; set; }
        public string ZagsCode { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string ActCodeUpdate { get; set; }
        public DateTime? ActDateUpdate { get; set; }
        public string ActTextUpdate { get; set; }
        public string FioOld { get; set; }
        public string ActNameBirth { get; set; }
        public string ActNumberBirth { get; set; }
        public DateTime? ActDateBirth { get; set; }
        public string ActZagsCodeBirth { get; set; }
        public string DocumentBasicCode { get; set; }
        public string DocumentBasicSerialNumber { get; set; }
        public DateTime? DocumentBasicDate { get; set; }
        public string DocumentBasicIssuer { get; set; }
    }
}
