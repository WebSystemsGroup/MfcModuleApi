using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprSmevTypeRequest
    {
        public SprSmevTypeRequest()
        {
            SprSmevRequests = new HashSet<SprSmevRequest>();
        }

        public short Id { get; set; }
        public string TypeName { get; set; }
        public string Commentt { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }

        public virtual ICollection<SprSmevRequest> SprSmevRequests { get; set; }
    }
}
