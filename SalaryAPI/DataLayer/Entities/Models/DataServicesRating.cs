using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataServicesRating
    {
        public Guid Id { get; set; }
        public Guid SprServicesSubId { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public long Rating { get; set; }

        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual SprServicesSub SprServicesSub { get; set; }
    }
}
