using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesProviderMfc
    {
        public Guid Id { get; set; }
        public Guid SprServicesProviderId { get; set; }
        public Guid SprEmployeesMfcId { get; set; }

        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual SprServicesProvider SprServicesProvider { get; set; }
    }
}
