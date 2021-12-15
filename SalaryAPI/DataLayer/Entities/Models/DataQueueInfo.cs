using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataQueueInfo
    {
        public Guid Id { get; set; }
        public Guid DataQueueId { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public int MfcId { get; set; }
        public string MfcName { get; set; }
        public int CountWindows { get; set; }
        public int IdleCountWindows { get; set; }
        public int CountCustomerLong { get; set; }
        public int CountCustomerLittle { get; set; }
        public TimeSpan MinWaitTime { get; set; }
        public TimeSpan MaxWaitTime { get; set; }
        public TimeSpan AverageWaitingTime { get; set; }

        public virtual DataQueue DataQueue { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
    }
}
