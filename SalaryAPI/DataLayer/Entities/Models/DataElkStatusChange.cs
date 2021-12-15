using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataElkStatusChange
    {
        public Guid Id { get; set; }
        public Guid DataElkOrderId { get; set; }
        public int Mode { get; set; }
        public DateTime? Eventdate { get; set; }
        public string Eventcomment { get; set; }
        public string Eventauthor { get; set; }
        public string Statusorgcode { get; set; }
        public int? Statustechcode { get; set; }
        public short? Cancelallowed { get; set; }
        public short? Sendmessageallowed { get; set; }
        public string Paymentsource { get; set; }
        public string Paymentuin { get; set; }
        public string Paymentdescription { get; set; }
        public string Infocode { get; set; }
        public string Invitecode { get; set; }
        public string InviteAction { get; set; }
        public string Orgname { get; set; }
        public string Address { get; set; }
        public DateTime? Invitestartdate { get; set; }
        public DateTime? Inviteenddate { get; set; }
        public string Commentt { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateSent { get; set; }
        public string Responsecode { get; set; }
        public string ResponsecodeDescription { get; set; }
        public byte[] RequestXml { get; set; }
        public byte[] ResponseXml { get; set; }
        public string MessageId { get; set; }
    }
}
