using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataTaskboard
    {
        public Guid Id { get; set; }
        public string TaskText { get; set; }
        public string Status { get; set; }
        public int Position { get; set; }
        public Guid SprEmployeesId { get; set; }
        public DateTime SetDate { get; set; }
    }
}
