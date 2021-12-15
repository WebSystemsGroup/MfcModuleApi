using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataEpguSubsRegOffice
    {
        public string Region { get; set; }
        public Guid Id { get; set; }
        public string OfficeName { get; set; }
        public string OfficeNameSmall { get; set; }
        public string OfficeAdress { get; set; }
        public string OfficeCodeFias { get; set; }
        public string OfficeTel { get; set; }
        public string OfficeEmail { get; set; }
        public string OfficeSchedule { get; set; }
    }
}
