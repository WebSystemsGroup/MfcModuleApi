using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataServicesAisOpvAnketStatus
    {
        public Guid Id { get; set; }
        public Guid DataServicesSmevRequestId { get; set; }
        public string RegistrationNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string DocumentSeries { get; set; }
        public string DocumentNumber { get; set; }
        public int AnketStatus { get; set; }
        public DateTime AnketStatusDatetime { get; set; }
        public string AnketStatusName { get; set; }
        public string AnketStatusComment { get; set; }
        public int AnketType { get; set; }
    }
}
