using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataEmployeesReminder
    {
        public Guid Id { get; set; }
        public string DataServicesInfoId { get; set; }
        public string Commentt { get; set; }
        public DateTime SetDate { get; set; }
        public Guid SprEmployeesId { get; set; }
        public DateTime? DateReminder { get; set; }
        public string CustomerName { get; set; }
        public string CustomerTel1 { get; set; }
        public string CustomerTel2 { get; set; }
        public string CustomerEmail { get; set; }
        public string ServiceName { get; set; }
        public DateTime? DateAdd { get; set; }

        public virtual DataServicesInfo DataServicesInfo { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
    }
}
