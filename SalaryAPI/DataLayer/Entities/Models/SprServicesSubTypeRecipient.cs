using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSubTypeRecipient
    {
        public SprServicesSubTypeRecipient()
        {
            ArchiveServices = new HashSet<ArchiveService>();
            ArchiveServicesCustomers = new HashSet<ArchiveServicesCustomer>();
            DataServices = new HashSet<DataService>();
            DataServicesCustomers = new HashSet<DataServicesCustomer>();
            SprServicesSubCustomers = new HashSet<SprServicesSubCustomer>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }
        public string Commentt { get; set; }
        public int IdParent { get; set; }

        public virtual ICollection<ArchiveService> ArchiveServices { get; set; }
        public virtual ICollection<ArchiveServicesCustomer> ArchiveServicesCustomers { get; set; }
        public virtual ICollection<DataService> DataServices { get; set; }
        public virtual ICollection<DataServicesCustomer> DataServicesCustomers { get; set; }
        public virtual ICollection<SprServicesSubCustomer> SprServicesSubCustomers { get; set; }
    }
}
