using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataServicesIncomingSmevRequest
    {
        public Guid Id { get; set; }
        public int SprSmevRequestId { get; set; }
        public string Oktmo { get; set; }
        public DateTime DateRequest { get; set; }
        public TimeSpan TimeRequest { get; set; }
        public DateTime? DateResponse { get; set; }
        public TimeSpan? TimeResponse { get; set; }
        public byte[] RequestData { get; set; }
        public byte[] ResponseData { get; set; }
        public Guid? SprEmployeesId { get; set; }
        public Guid? DataServicesId { get; set; }
        public string DataServicesInfoId { get; set; }
        public Guid? SprEmployeesMfcId { get; set; }

        public virtual DataService DataServices { get; set; }
        public virtual DataServicesInfo DataServicesInfo { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprSmevRequest SprSmevRequest { get; set; }
    }
}
