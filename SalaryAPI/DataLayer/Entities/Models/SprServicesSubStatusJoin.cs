using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSubStatusJoin
    {
        public Guid Id { get; set; }
        public int SprServicesSubStatusId { get; set; }
        public int SprRoutesStageId { get; set; }

        public virtual SprRoutesStage SprRoutesStage { get; set; }
        public virtual SprServicesSubStatus SprServicesSubStatus { get; set; }
    }
}
