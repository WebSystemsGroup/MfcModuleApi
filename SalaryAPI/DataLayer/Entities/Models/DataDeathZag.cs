using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataDeathZag
    {
        public Guid Id { get; set; }
        public string ActNumber { get; set; }
        public DateTime ActDate { get; set; }
        public string ZagsCode { get; set; }
        public string ActStatus { get; set; }
        public string SerialDocumentDeath { get; set; }
        public string NumberDocumentDeath { get; set; }
        public bool? IsDeath { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string Fio { get; set; }
        public string BirthPlace { get; set; }
        public string BirthDate { get; set; }
        public string Address { get; set; }
        public string DocumentCode { get; set; }
        public string DocumentSerialNumber { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string DocumentIssuer { get; set; }
        public string DeathDate { get; set; }
        public TimeSpan? DeathTime { get; set; }
        public string DeathPlace { get; set; }
        public string ActCodeUpdate { get; set; }
        public DateTime? ActDateUpdate { get; set; }
        public string ActTextUpdate { get; set; }
        public string DocumentNameUpdate { get; set; }
        public string DocumentSerialNumberUpdate { get; set; }
        public DateTime? DocumentDateUpdate { get; set; }
        public string DocumentIssuerUpdate { get; set; }
        public string ActVersionNumber { get; set; }
        public DateTime ActVersionDate { get; set; }
        public DateTime? DateDocumentDeath { get; set; }
        public string NationalityCode { get; set; }
        public string MaritalStatusCode { get; set; }
        public string EducationCode { get; set; }
        public string EmploymentCode { get; set; }
        public string DeathCause { get; set; }
        public string DeathCircumstancesCode { get; set; }
        public string DeathPlaceCode { get; set; }
        public string SetCauseDeathPersonCode { get; set; }
        public string SetCauseDeathPersonFio { get; set; }
        public string SetCauseDeathBasic { get; set; }
        public string DocumentConfirmDeathCode { get; set; }
        public string DocumentConfirmDeathSerialNumber { get; set; }
        public DateTime? DocumentConfirmDeathDate { get; set; }
        public string DocumentConfirmDeathIssuer { get; set; }
    }
}
