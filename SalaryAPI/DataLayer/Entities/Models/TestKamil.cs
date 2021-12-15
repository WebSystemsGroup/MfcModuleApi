using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class TestKamil
    {
        public string DataServicesInfoId { get; set; }
        public string FtpLogin { get; set; }
        public string FtpPassword { get; set; }
        public string FtpFolder { get; set; }
        public string FtpServer { get; set; }
    }
}
