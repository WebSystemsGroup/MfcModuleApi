using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataBirthZag
    {
        public Guid Id { get; set; }
        public string ActNumber { get; set; }
        public DateTime? ActDate { get; set; }
        public string ActVersionNumber { get; set; }
        public DateTime? ActVersionDate { get; set; }
        public DateTime? ActStatusDate { get; set; }
        public string ActStatus { get; set; }
        public string SerialDocumentBirth { get; set; }
        public string NumberDocumentBirth { get; set; }
        public DateTime? DateDocumentBirth { get; set; }
        public string Fio { get; set; }
        public string BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string DocumentConfirmBirthCode { get; set; }
        public string DocumentConfirmBirthSerialNumber { get; set; }
        public DateTime? DocumentConfirmBirthDate { get; set; }
        public string EducationCode { get; set; }
        public string BodyWeight { get; set; }
        public string EmploymentCode { get; set; }
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
        public bool? IsLiveBorn { get; set; }
        public string ZagsCode { get; set; }
        public string Gender { get; set; }
        public string DocumentConfirmBirthIssuer { get; set; }
        public string Country { get; set; }
        public string ActCodeUpdate { get; set; }
        public DateTime? ActDateUpdate { get; set; }
        public string ActTextUpdate { get; set; }
    }
}
