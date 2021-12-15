using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSubStateTask
    {
        public Guid Id { get; set; }
        public Guid SprServicesSubId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateStop { get; set; }
        public string TaskCommentt { get; set; }

        public virtual SprServicesSub SprServicesSub { get; set; }
    }
}
