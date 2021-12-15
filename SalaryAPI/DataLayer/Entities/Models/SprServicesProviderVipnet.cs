using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesProviderVipnet
    {
        public short Id { get; set; }
        public string ProviderName { get; set; }
        public string FtpServer { get; set; }
        public string FtpUser { get; set; }
        public string FtpPass { get; set; }
        public string FtpIn { get; set; }
        public string FtpOut { get; set; }
        public string FtpUnc { get; set; }
    }
}
