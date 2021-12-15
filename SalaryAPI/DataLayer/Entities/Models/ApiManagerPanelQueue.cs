using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ApiManagerPanelQueue
    {
        public ApiManagerPanelQueue()
        {
            ApiManagerPanelQueueInfos = new HashSet<ApiManagerPanelQueueInfo>();
        }

        public Guid Id { get; set; }
        public DateTime DateQuery { get; set; }
        public DateTime DateAnswer { get; set; }
        public string Commentt { get; set; }
        public int? CountWorkWindows { get; set; }
        public int? CountCustomerLong { get; set; }
        public int? CountCustomerLittle { get; set; }
        public TimeSpan? MinWaitTime { get; set; }
        public TimeSpan? MaxWaitTime { get; set; }
        public TimeSpan? AverageWaitingTime { get; set; }
        public int? CountActiveOperator { get; set; }

        public virtual ICollection<ApiManagerPanelQueueInfo> ApiManagerPanelQueueInfos { get; set; }
    }
}
