using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataQueueDay
    {
        public Guid Id { get; set; }
        public int CountReceived { get; set; }
        public int CountExecuted { get; set; }
        public DateTime DateQuery { get; set; }
        public string Commentt { get; set; }
    }
}
