using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprEmployeesMfcFtp
    {
        public SprEmployeesMfcFtp()
        {
            ArchiveServicesCustomerCalls = new HashSet<ArchiveServicesCustomerCall>();
            ArchiveServicesFileResults = new HashSet<ArchiveServicesFileResult>();
            ArchiveServicesFiles = new HashSet<ArchiveServicesFile>();
            DataCallbackCalls = new HashSet<DataCallbackCall>();
            DataIncomingCalls = new HashSet<DataIncomingCall>();
            DataServicesCustomerCalls = new HashSet<DataServicesCustomerCall>();
            DataServicesFileResults = new HashSet<DataServicesFileResult>();
            DataServicesFiles = new HashSet<DataServicesFile>();
            SprEmployeesMfcFtpJoins = new HashSet<SprEmployeesMfcFtpJoin>();
        }

        public Guid Id { get; set; }
        public string MfcFtpServer { get; set; }
        public string MfcFtpFolder { get; set; }
        public string MfcFtpLogin { get; set; }
        public string MfcFtpPass { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public string Commentt { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }

        public virtual ICollection<ArchiveServicesCustomerCall> ArchiveServicesCustomerCalls { get; set; }
        public virtual ICollection<ArchiveServicesFileResult> ArchiveServicesFileResults { get; set; }
        public virtual ICollection<ArchiveServicesFile> ArchiveServicesFiles { get; set; }
        public virtual ICollection<DataCallbackCall> DataCallbackCalls { get; set; }
        public virtual ICollection<DataIncomingCall> DataIncomingCalls { get; set; }
        public virtual ICollection<DataServicesCustomerCall> DataServicesCustomerCalls { get; set; }
        public virtual ICollection<DataServicesFileResult> DataServicesFileResults { get; set; }
        public virtual ICollection<DataServicesFile> DataServicesFiles { get; set; }
        public virtual ICollection<SprEmployeesMfcFtpJoin> SprEmployeesMfcFtpJoins { get; set; }
    }
}
