using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataQueueMonth
    {
        public Guid Id { get; set; }
        public DateTime DateQuery { get; set; }
        public int CountReceivedWeek { get; set; }
        public int CountExecutedWeek { get; set; }
        public int CountReceivedMonth { get; set; }
        public int CountExecutedMonth { get; set; }
        public int CountExpired { get; set; }
        public decimal PercentExpired { get; set; }
        public int CountExpiredStage { get; set; }
        public decimal PercentExpiredStage { get; set; }
        public string Commentt { get; set; }
        public int CountReceivedQuarter { get; set; }
        public int CountReceivedYear { get; set; }
        public int CountExecutedQuarter { get; set; }
        public int CountExecutedYear { get; set; }
    }
}
