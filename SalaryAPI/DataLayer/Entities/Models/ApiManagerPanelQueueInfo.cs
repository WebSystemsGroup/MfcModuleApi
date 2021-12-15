using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ApiManagerPanelQueueInfo
    {
        public Guid Id { get; set; }
        public Guid ApiManagerPanelQueueId { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public int MfcId { get; set; }
        public string MfcName { get; set; }
        public int? CountWorkWindows { get; set; }
        public int? CountCustomerLong { get; set; }
        public int? CountCustomerLittle { get; set; }
        public TimeSpan? MinWaitTime { get; set; }
        public TimeSpan? MaxWaitTime { get; set; }
        public TimeSpan? AverageWaitingTime { get; set; }
        public int? CountActiveOperator { get; set; }

        public virtual ApiManagerPanelQueue ApiManagerPanelQueue { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
    }
}
