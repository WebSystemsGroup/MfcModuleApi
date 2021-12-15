using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchiveService
    {
        public ArchiveService()
        {
            ArchiveCoverLetters = new HashSet<ArchiveCoverLetter>();
            ArchiveServicesCommentts = new HashSet<ArchiveServicesCommentt>();
            ArchiveServicesCustomerCalls = new HashSet<ArchiveServicesCustomerCall>();
            ArchiveServicesCustomerMessages = new HashSet<ArchiveServicesCustomerMessage>();
            ArchiveServicesCustomers = new HashSet<ArchiveServicesCustomer>();
            ArchiveServicesDocuments = new HashSet<ArchiveServicesDocument>();
            ArchiveServicesFileResults = new HashSet<ArchiveServicesFileResult>();
            ArchiveServicesParametr1s = new HashSet<ArchiveServicesParametr1>();
            ArchiveServicesParametrs = new HashSet<ArchiveServicesParametr>();
            ArchiveServicesPayments = new HashSet<ArchiveServicesPayment>();
            ArchiveServicesRoutesStages = new HashSet<ArchiveServicesRoutesStage>();
            ArchiveServicesSmevRequests = new HashSet<ArchiveServicesSmevRequest>();
        }

        public Guid Id { get; set; }
        public string ArchiveServicesInfoId { get; set; }
        public Guid ArchiveServicesIdParent { get; set; }
        public Guid ArchiveServicesDocumentIdParent { get; set; }
        public int SprServicesSubTrId { get; set; }
        public DateTime DateEnter { get; set; }
        public decimal TariffState { get; set; }
        public bool TariffEdit { get; set; }
        public DateTime? DateFinishFact { get; set; }
        public DateTime DateFinishTotal { get; set; }
        public string Commentt { get; set; }
        public int SprServicesSubStatusId { get; set; }
        public Guid SprServicesSubId { get; set; }
        public int CountDayExecution { get; set; }
        public short SprServicesSubWeekId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public string EmployeesFio { get; set; }
        public int CountDayProcessing { get; set; }
        public int CountDayReturn { get; set; }
        public bool ReportSelect { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public Guid? SprEmployeesMfcIdExecution { get; set; }
        public Guid? SprEmployeesIdExecution { get; set; }
        public int SprEmployeesJobPosId { get; set; }
        public int? SprEmployeesJobPosIdExecution { get; set; }
        public string SprServicesSubName { get; set; }
        public string SprServicesProviderName { get; set; }
        public Guid SprServicesProviderId { get; set; }
        public bool? IasMkgu { get; set; }
        public string FrguTargetId { get; set; }
        public string FrguServicesId { get; set; }
        public string FrguProviderId { get; set; }
        public int? SprServicesSubTariffTypeId { get; set; }
        public int? NodeNumber { get; set; }
        public string ServicesSubName { get; set; }
        public string ServicesProviderName { get; set; }
        public string EmployeesFioExecuted { get; set; }
        public string EmployeesMfcName { get; set; }
        public string EmployeesJobPosName { get; set; }
        public string EmployeesMfcNameExecuted { get; set; }
        public string EmployeesJobPosNameExecuted { get; set; }
        public decimal? TariffMfc { get; set; }
        public Guid? SprEmployeesMfcRemoteWorkplaceId { get; set; }

        public virtual ArchiveServicesInfo ArchiveServicesInfo { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprEmployee SprEmployeesIdExecutionNavigation { get; set; }
        public virtual SprEmployeesJobPo SprEmployeesJobPos { get; set; }
        public virtual SprEmployeesJobPo SprEmployeesJobPosIdExecutionNavigation { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfcIdExecutionNavigation { get; set; }
        public virtual SprEmployeesMfcRemoteWorkplace SprEmployeesMfcRemoteWorkplace { get; set; }
        public virtual SprServicesSubStatus SprServicesSubStatus { get; set; }
        public virtual SprServicesSubTypeRecipient SprServicesSubTr { get; set; }
        public virtual SprServicesSubWeek SprServicesSubWeek { get; set; }
        public virtual ICollection<ArchiveCoverLetter> ArchiveCoverLetters { get; set; }
        public virtual ICollection<ArchiveServicesCommentt> ArchiveServicesCommentts { get; set; }
        public virtual ICollection<ArchiveServicesCustomerCall> ArchiveServicesCustomerCalls { get; set; }
        public virtual ICollection<ArchiveServicesCustomerMessage> ArchiveServicesCustomerMessages { get; set; }
        public virtual ICollection<ArchiveServicesCustomer> ArchiveServicesCustomers { get; set; }
        public virtual ICollection<ArchiveServicesDocument> ArchiveServicesDocuments { get; set; }
        public virtual ICollection<ArchiveServicesFileResult> ArchiveServicesFileResults { get; set; }
        public virtual ICollection<ArchiveServicesParametr1> ArchiveServicesParametr1s { get; set; }
        public virtual ICollection<ArchiveServicesParametr> ArchiveServicesParametrs { get; set; }
        public virtual ICollection<ArchiveServicesPayment> ArchiveServicesPayments { get; set; }
        public virtual ICollection<ArchiveServicesRoutesStage> ArchiveServicesRoutesStages { get; set; }
        public virtual ICollection<ArchiveServicesSmevRequest> ArchiveServicesSmevRequests { get; set; }
    }
}
