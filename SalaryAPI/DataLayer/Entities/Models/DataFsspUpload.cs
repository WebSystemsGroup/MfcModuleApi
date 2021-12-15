using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataFsspUpload
    {
        public Guid Id { get; set; }
        public string DataServicesInfoId { get; set; }
        public string CustomerFio { get; set; }
        public DateTime? DocumentBirthDate { get; set; }
        public string CustomerTel1 { get; set; }
        public string CustomerTel2 { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }
        public string EmployeesMfcName { get; set; }
        public DateTime SetDate { get; set; }
        public DateTime? DateSend { get; set; }
        public string CustomerKpp { get; set; }
        public string CustomerInn { get; set; }
        public string CustomerContragentName { get; set; }
        public string IpNumbers { get; set; }
    }
}
