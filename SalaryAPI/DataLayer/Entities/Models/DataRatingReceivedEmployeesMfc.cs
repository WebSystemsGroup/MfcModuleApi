using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataRatingReceivedEmployeesMfc
    {
        public Guid Id { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public int Rating { get; set; }
        public int Position { get; set; }
        public string EmployeesMfcName { get; set; }
        public int PositionMoving { get; set; }

        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
    }
}
