using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprQueueJoinMfc
    {
        public Guid Id { get; set; }
        public Guid? SprEmployeesMfc { get; set; }
        public int? SprMfcId { get; set; }

        public virtual SprEmployeesMfc SprEmployeesMfcNavigation { get; set; }
    }
}
