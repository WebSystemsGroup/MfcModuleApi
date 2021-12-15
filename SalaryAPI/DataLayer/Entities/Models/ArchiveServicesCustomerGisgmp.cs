using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchiveServicesCustomerGisgmp
    {
        public Guid Id { get; set; }
        public Guid ArchiveServicesCustomerId { get; set; }
        public decimal Gisgmp { get; set; }
        public DateTime? SetDate { get; set; }
        public string SetEmployeeFio { get; set; }

        public virtual ArchiveServicesCustomer ArchiveServicesCustomer { get; set; }
    }
}
