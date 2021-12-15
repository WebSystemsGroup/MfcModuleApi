using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataIasMkguProviderLoad
    {
        public string FrguProviderId { get; set; }
        public string ProviderName { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
