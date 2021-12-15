using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataIasMkguInfomatUpload
    {
        public Guid Id { get; set; }
        public string DataServicesInfoId { get; set; }
        public string FrguProviderId { get; set; }
        public string FrguServicesId { get; set; }
        public string FrguTargetId { get; set; }
        public string Okato { get; set; }
        public DateTime? DateEnter { get; set; }
        public int? MfcVendorId { get; set; }
        public string PackedId { get; set; }
        public DateTime SetDate { get; set; }
        public int? UserId { get; set; }
        public string UserMail { get; set; }
        public Guid? SprEmployeesMfcId { get; set; }
        public Guid? SprEmployeesId { get; set; }
        public int? SprEmployeesJobPosId { get; set; }
        public string EmployeesFio { get; set; }
        public string EmployeesMfcName { get; set; }
        public string EmployeesJobPosName { get; set; }
        public string MessageId { get; set; }
        public string FrguProcedureId { get; set; }
    }
}
