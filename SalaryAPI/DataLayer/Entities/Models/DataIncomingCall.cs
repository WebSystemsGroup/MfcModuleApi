using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataIncomingCall
    {
        public Guid Id { get; set; }
        public string CustomerTel { get; set; }
        public string CustomerName { get; set; }
        public DateTime DateCall { get; set; }
        public Guid SprEmployeesMfcFtpId { get; set; }
        public string SoundFormat { get; set; }
        public string TimeTalk { get; set; }
        public bool SaveFtp { get; set; }
        public Guid? SprEmployeesId { get; set; }
        public Guid? SprEmployeesMfcId { get; set; }

        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual SprEmployeesMfcFtp SprEmployeesMfcFtp { get; set; }
    }
}
