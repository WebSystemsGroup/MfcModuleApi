using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ApiUser
    {
        public Guid Id { get; set; }
        public string UserLogin { get; set; }
        public string UserPass { get; set; }
        public DateTime? SetDate { get; set; }
        public string Commentt { get; set; }
        public bool? Active { get; set; }
    }
}
