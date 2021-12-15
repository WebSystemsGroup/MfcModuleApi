using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataCallbackCall
    {
        public Guid Id { get; set; }
        public Guid DataCallbackId { get; set; }
        public DateTime DateCall { get; set; }
        public string CallDuration { get; set; }
        public string EmployeeFio { get; set; }
        public Guid SprEmployeesId { get; set; }
        public string MfcName { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public Guid SprEmployeesMfcFtpId { get; set; }
        public bool? SaveFtp { get; set; }

        public virtual DataCallback DataCallback { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual SprEmployeesMfcFtp SprEmployeesMfcFtp { get; set; }
    }
}
