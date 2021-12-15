using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataServicesAisOpvChat
    {
        public Guid Id { get; set; }
        public Guid DataServicesSmevRequestId { get; set; }
        public int ChatDirection { get; set; }
        public string ChatMessage { get; set; }
        public DateTime? ReceivedOrSentTime { get; set; }
        public bool? OutcomingMessageInvalid { get; set; }
        public string Sender { get; set; }

        public virtual DataServicesSmevRequest DataServicesSmevRequest { get; set; }
    }
}
