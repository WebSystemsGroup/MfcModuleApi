using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class TestFtpFile
    {
        public Guid? Id { get; set; }
        public string DataServicesInfoId { get; set; }
        public string MfcFtpServer { get; set; }
        public string MfcFtpFolder { get; set; }
        public string MfcFtpLogin { get; set; }
        public string MfcFtpPass { get; set; }
        public bool? HasDownloaded { get; set; }
        public string Snils { get; set; }
        public string Fio { get; set; }
        public Guid Id2 { get; set; }
    }
}
