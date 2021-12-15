using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchiveServicesInfo
    {
        public ArchiveServicesInfo()
        {
            ArchiveServices = new HashSet<ArchiveService>();
            ArchiveServicesCommentts = new HashSet<ArchiveServicesCommentt>();
            ArchiveServicesCustomerCalls = new HashSet<ArchiveServicesCustomerCall>();
            ArchiveServicesCustomerMessages = new HashSet<ArchiveServicesCustomerMessage>();
            ArchiveServicesCustomers = new HashSet<ArchiveServicesCustomer>();
            ArchiveServicesDocuments = new HashSet<ArchiveServicesDocument>();
            ArchiveServicesFileResults = new HashSet<ArchiveServicesFileResult>();
            ArchiveServicesFiles = new HashSet<ArchiveServicesFile>();
            ArchiveServicesParametr1s = new HashSet<ArchiveServicesParametr1>();
            ArchiveServicesParametrs = new HashSet<ArchiveServicesParametr>();
            ArchiveServicesPayments = new HashSet<ArchiveServicesPayment>();
            ArchiveServicesRoutesStages = new HashSet<ArchiveServicesRoutesStage>();
            ArchiveServicesSmevRequests = new HashSet<ArchiveServicesSmevRequest>();
            ArchiveServicesViewLogs = new HashSet<ArchiveServicesViewLog>();
        }

        public string Id { get; set; }
        public string Commentt { get; set; }
        public DateTime SetDate { get; set; }
        public DateTime? DateFinishTotal { get; set; }
        public Guid? SprEmployeesMfcRemoteWorkplaceId { get; set; }
        public short? SmsRating { get; set; }
        public string RemoteWorkplaceName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerTel1 { get; set; }
        public string CustomerTel2 { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }
        public string AlertName { get; set; }
        public string ServiceName { get; set; }
        public string ServiceProviderName { get; set; }
        public string StatusName { get; set; }
        public string EmployeesFio { get; set; }
        public string EmployeesFioExecution { get; set; }
        public string EmployeesMfcName { get; set; }
        public short? PollIasMkgu { get; set; }
        public bool? PollRegionSms { get; set; }
        public int? SprAlertId { get; set; }
        public DateTime? DateFinishFact { get; set; }
        public string PollIasMkguName { get; set; }
        public string NumberTicketQueue { get; set; }
        public DateTime? DateAdd { get; set; }

        public virtual ICollection<ArchiveService> ArchiveServices { get; set; }
        public virtual ICollection<ArchiveServicesCommentt> ArchiveServicesCommentts { get; set; }
        public virtual ICollection<ArchiveServicesCustomerCall> ArchiveServicesCustomerCalls { get; set; }
        public virtual ICollection<ArchiveServicesCustomerMessage> ArchiveServicesCustomerMessages { get; set; }
        public virtual ICollection<ArchiveServicesCustomer> ArchiveServicesCustomers { get; set; }
        public virtual ICollection<ArchiveServicesDocument> ArchiveServicesDocuments { get; set; }
        public virtual ICollection<ArchiveServicesFileResult> ArchiveServicesFileResults { get; set; }
        public virtual ICollection<ArchiveServicesFile> ArchiveServicesFiles { get; set; }
        public virtual ICollection<ArchiveServicesParametr1> ArchiveServicesParametr1s { get; set; }
        public virtual ICollection<ArchiveServicesParametr> ArchiveServicesParametrs { get; set; }
        public virtual ICollection<ArchiveServicesPayment> ArchiveServicesPayments { get; set; }
        public virtual ICollection<ArchiveServicesRoutesStage> ArchiveServicesRoutesStages { get; set; }
        public virtual ICollection<ArchiveServicesSmevRequest> ArchiveServicesSmevRequests { get; set; }
        public virtual ICollection<ArchiveServicesViewLog> ArchiveServicesViewLogs { get; set; }
    }
}
