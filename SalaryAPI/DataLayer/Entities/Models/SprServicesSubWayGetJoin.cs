using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSubWayGetJoin
    {
        public Guid Id { get; set; }
        public Guid SprServicesSubId { get; set; }
        public Guid SprServicesSubWayGetId { get; set; }
        public string SetEmployeesFio { get; set; }
        public DateTime SetDate { get; set; }

        public virtual SprServicesSub SprServicesSub { get; set; }
        public virtual SprServicesSubWayGet SprServicesSubWayGet { get; set; }
    }
}
