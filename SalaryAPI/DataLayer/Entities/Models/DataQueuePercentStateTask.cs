using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataQueuePercentStateTask
    {
        public Guid Id { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public decimal Percent { get; set; }
        public DateTime DateQuery { get; set; }
        public string Commentt { get; set; }

        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
    }
}
