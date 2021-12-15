using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataRatingTable
    {
        public Guid Id { get; set; }
        public string DataServicesInfoId { get; set; }
        public DateTime? DateTimeInsert { get; set; }
        public int? Rate { get; set; }
        public string Comment { get; set; }
        public Guid? SprEmployeesMfcId { get; set; }
        public string EmployeesFio { get; set; }
        public string ServiceName { get; set; }
        public short? SourceRating { get; set; }
    }
}
