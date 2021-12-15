using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSubStatus
    {
        public SprServicesSubStatus()
        {
            ArchiveServices = new HashSet<ArchiveService>();
            DataReportExecuteds = new HashSet<DataReportExecuted>();
            DataServices = new HashSet<DataService>();
            SprServicesSubStatusJoins = new HashSet<SprServicesSubStatusJoin>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; }
        public string Commentt { get; set; }

        public virtual ICollection<ArchiveService> ArchiveServices { get; set; }
        public virtual ICollection<DataReportExecuted> DataReportExecuteds { get; set; }
        public virtual ICollection<DataService> DataServices { get; set; }
        public virtual ICollection<SprServicesSubStatusJoin> SprServicesSubStatusJoins { get; set; }
    }
}
