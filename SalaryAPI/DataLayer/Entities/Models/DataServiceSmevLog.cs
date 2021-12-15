using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataServiceSmevLog
    {
        public Guid Id { get; set; }
        public DateTime SetDate { get; set; }
        public string LogText { get; set; }
        public short? LogType { get; set; }
        public Guid? DataServicesSmevRequestId { get; set; }
    }
}
