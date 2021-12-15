using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ApiManagerPanelStateTask
    {
        public Guid Id { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public decimal Percent { get; set; }
        public DateTime DateQuery { get; set; }
        public string Commentt { get; set; }
        public int? CountServiceFact { get; set; } 

        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
    }
}
