using System;

namespace SalaryCore.Contracts.Common
{
    public class QueueMfc
    {
        public Guid MfcId { get; set; }
        public string MfcName { get; set; }
        public int MfcQueueId { get; set; }
        public int CountActiveOperator { get; set; }
    }

    public class QueueInfo
    {
        public int? active_windows { get; set; }
        public int? inactive_windows { get; set; }
        public TimeSpan? waiting_time_in_queue_average { get; set; }
        public int? work_windows { get; set; }
        public TimeSpan? waiting_time_in_queue_minimum { get; set; }
        public TimeSpan? waiting_time_in_queue_maximum { get; set; }
        public int? waiting_long_time_in_queue_number { get; set; }
        public int? waiting_normal_time_in_queue_number { get; set; }
    }
}
