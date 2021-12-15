using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataServicesElplatInfo
    {
        public Guid Id { get; set; }
        public Guid? DataServicesElplatId { get; set; }
        public int? Code { get; set; }
        public string Commentt { get; set; }
        public int? Result { get; set; }
        public string Descr { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Version { get; set; }
        public bool? Status { get; set; }
        public string Uip { get; set; }

        public virtual DataServicesElplat DataServicesElplat { get; set; }
    }
}
