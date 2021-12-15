using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class TestKamil1
    {
        public Guid Id { get; set; }
        public string Fio { get; set; }
        public string DataServicesInfoId { get; set; }
        public string MfcFtpServer { get; set; }
        public string MfcFtpFolder { get; set; }
        public string MfcFtpLogin { get; set; }
        public string MfcFtpPass { get; set; }
    }
}
