using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSubWeek
    {
        public SprServicesSubWeek()
        {
            ArchiveServices = new HashSet<ArchiveService>();
            ArchiveServicesRoutesStages = new HashSet<ArchiveServicesRoutesStage>();
            DataServices = new HashSet<DataService>();
            DataServicesRoutesStages = new HashSet<DataServicesRoutesStage>();
            SprServicesSubStops = new HashSet<SprServicesSubStop>();
            SprServicesSubTariffs = new HashSet<SprServicesSubTariff>();
            SprSmevRequests = new HashSet<SprSmevRequest>();
        }

        public short Id { get; set; }
        public string TypeName { get; set; }
        public string Commentt { get; set; }
        public DateTime? SetDate { get; set; }
        public string SetEmployeesFio { get; set; }

        public virtual ICollection<ArchiveService> ArchiveServices { get; set; }
        public virtual ICollection<ArchiveServicesRoutesStage> ArchiveServicesRoutesStages { get; set; }
        public virtual ICollection<DataService> DataServices { get; set; }
        public virtual ICollection<DataServicesRoutesStage> DataServicesRoutesStages { get; set; }
        public virtual ICollection<SprServicesSubStop> SprServicesSubStops { get; set; }
        public virtual ICollection<SprServicesSubTariff> SprServicesSubTariffs { get; set; }
        public virtual ICollection<SprSmevRequest> SprSmevRequests { get; set; }
    }
}
