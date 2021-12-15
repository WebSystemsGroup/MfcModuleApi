using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataQueueAvgTime
    {
        public Guid Id { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public decimal AvgTime { get; set; }
        public DateTime DateRegistration { get; set; }
        public DateTime SetDate { get; set; }
        public DateTime? DateAdd { get; set; }

        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
    }
}
