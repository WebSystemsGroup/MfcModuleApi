using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataPollRegionSm
    {
        public Guid Id { get; set; }
        public string DataServicesInfoId { get; set; }
        public string CustomerTel { get; set; }
        public string CustomerName { get; set; }
        public string SmsTextSend { get; set; }
        public string SmsTextAnswer { get; set; }
        public short? SmsRating { get; set; }
        public DateTime? DateSend { get; set; }
        public DateTime? DateAnswer { get; set; }
        public DateTime? SetDate { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public short SmsStatus { get; set; }
        public string ServiceSubName { get; set; }
        public string EmployeeFio { get; set; }

        public virtual DataServicesInfo DataServicesInfo { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
    }
}
