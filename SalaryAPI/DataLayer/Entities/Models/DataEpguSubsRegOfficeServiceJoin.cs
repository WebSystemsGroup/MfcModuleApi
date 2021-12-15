using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataEpguSubsRegOfficeServiceJoin
    {
        public string Region { get; set; }
        public Guid Id { get; set; }
        public string DataEpguSubsRegOptionsServiceId { get; set; }
        public Guid DataEpguSubsRegOfficeId { get; set; }
    }
}
