using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataService
    {
        public DataService()
        {
            DataCoverLetters = new HashSet<DataCoverLetter>();
            DataServicesCommentts = new HashSet<DataServicesCommentt>();
            DataServicesCustomerCalls = new HashSet<DataServicesCustomerCall>();
            DataServicesCustomerMessages = new HashSet<DataServicesCustomerMessage>();
            DataServicesCustomers = new HashSet<DataServicesCustomer>();
            DataServicesDocuments = new HashSet<DataServicesDocument>();
            DataServicesFileResults = new HashSet<DataServicesFileResult>();
            DataServicesIncomingSmevRequests = new HashSet<DataServicesIncomingSmevRequest>();
            DataServicesParametr1s = new HashSet<DataServicesParametr1>();
            DataServicesParametrs = new HashSet<DataServicesParametr>();
            DataServicesPayments = new HashSet<DataServicesPayment>();
            DataServicesReestrs = new HashSet<DataServicesReestr>();
            DataServicesRoutesStages = new HashSet<DataServicesRoutesStage>();
            DataServicesSmevRequests = new HashSet<DataServicesSmevRequest>();
        }

        public Guid Id { get; set; }
        public string DataServicesInfoId { get; set; }
        public Guid DataServicesIdParent { get; set; }
        public Guid DataServicesDocumentIdParent { get; set; }
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
        public Guid? SprEmployeesIdCurrent { get; set; }
        public int? SprRoutesStageIdCurrent { get; set; }
        public DateTime? RoutesStageDateFinishReg { get; set; }
        public Guid SprServicesProviderId { get; set; }
        public DateTime? DateRead { get; set; }
        public string SetEmployeesFio { get; set; }
        public bool? IasMkgu { get; set; }
        public string FrguTargetId { get; set; }
        public string FrguServicesId { get; set; }
        public string FrguProviderId { get; set; }
        public int? SprServicesSubTariffTypeId { get; set; }
        public int? NodeNumber { get; set; }
        public Guid? SprEmployeesMfcIdCurrent { get; set; }
        public int? ServicesCount { get; set; }
        public DateTime? DateAdd { get; set; }
        public string ServicesSubName { get; set; }
        public string ServicesProviderName { get; set; }
        public string EmployeesFioExecuted { get; set; }
        public string EmployeesJobPosNameExecuted { get; set; }
        public string EmployeesMfcNameExecuted { get; set; }
        public string EmployeesMfcName { get; set; }
        public string EmployeesJobPosName { get; set; }
        public int? NumberCopies { get; set; }
        public decimal? TariffMfc { get; set; }
        public Guid? SprEmployeesMfcRemoteWorkplaceId { get; set; }

        public virtual DataServicesInfo DataServicesInfo { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprEmployee SprEmployeesIdExecutionNavigation { get; set; }
        public virtual SprEmployeesJobPo SprEmployeesJobPos { get; set; }
        public virtual SprEmployeesJobPo SprEmployeesJobPosIdExecutionNavigation { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfcIdExecutionNavigation { get; set; }
        public virtual SprEmployeesMfcRemoteWorkplace SprEmployeesMfcRemoteWorkplace { get; set; }
        public virtual SprServicesSub SprServicesSub { get; set; }
        public virtual SprServicesSubStatus SprServicesSubStatus { get; set; }
        public virtual SprServicesSubTypeRecipient SprServicesSubTr { get; set; }
        public virtual SprServicesSubWeek SprServicesSubWeek { get; set; }
        public virtual ICollection<DataCoverLetter> DataCoverLetters { get; set; }
        public virtual ICollection<DataServicesCommentt> DataServicesCommentts { get; set; }
        public virtual ICollection<DataServicesCustomerCall> DataServicesCustomerCalls { get; set; }
        public virtual ICollection<DataServicesCustomerMessage> DataServicesCustomerMessages { get; set; }
        public virtual ICollection<DataServicesCustomer> DataServicesCustomers { get; set; }
        public virtual ICollection<DataServicesDocument> DataServicesDocuments { get; set; }
        public virtual ICollection<DataServicesFileResult> DataServicesFileResults { get; set; }
        public virtual ICollection<DataServicesIncomingSmevRequest> DataServicesIncomingSmevRequests { get; set; }
        public virtual ICollection<DataServicesParametr1> DataServicesParametr1s { get; set; }
        public virtual ICollection<DataServicesParametr> DataServicesParametrs { get; set; }
        public virtual ICollection<DataServicesPayment> DataServicesPayments { get; set; }
        public virtual ICollection<DataServicesReestr> DataServicesReestrs { get; set; }
        public virtual ICollection<DataServicesRoutesStage> DataServicesRoutesStages { get; set; }
        public virtual ICollection<DataServicesSmevRequest> DataServicesSmevRequests { get; set; }
    }
}
