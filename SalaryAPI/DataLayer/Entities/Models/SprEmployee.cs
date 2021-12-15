using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprEmployee
    {
        public SprEmployee()
        {
            ArchiveCoverLetters = new HashSet<ArchiveCoverLetter>();
            ArchivePremia = new HashSet<ArchivePremium>();
            ArchivePremiumSteps = new HashSet<ArchivePremiumStep>();
            ArchiveRatingExecutedEmployees = new HashSet<ArchiveRatingExecutedEmployee>();
            ArchiveRatingReceivedEmployees = new HashSet<ArchiveRatingReceivedEmployee>();
            ArchiveServiceSprEmployees = new HashSet<ArchiveService>();
            ArchiveServiceSprEmployeesIdExecutionNavigations = new HashSet<ArchiveService>();
            ArchiveServicesCommenttRecipients = new HashSet<ArchiveServicesCommenttRecipient>();
            ArchiveServicesCommentts = new HashSet<ArchiveServicesCommentt>();
            ArchiveServicesCustomerCalls = new HashSet<ArchiveServicesCustomerCall>();
            ArchiveServicesCustomerMessages = new HashSet<ArchiveServicesCustomerMessage>();
            ArchiveServicesFiles = new HashSet<ArchiveServicesFile>();
            ArchiveServicesPayments = new HashSet<ArchiveServicesPayment>();
            ArchiveServicesRoutesStages = new HashSet<ArchiveServicesRoutesStage>();
            ArchiveServicesSmevRequests = new HashSet<ArchiveServicesSmevRequest>();
            ArchiveServicesViewLogs = new HashSet<ArchiveServicesViewLog>();
            DataCallbackCalls = new HashSet<DataCallbackCall>();
            DataCoverLetters = new HashSet<DataCoverLetter>();
            DataEmployeesAlerts = new HashSet<DataEmployeesAlert>();
            DataEmployeesInterviewAnswers = new HashSet<DataEmployeesInterviewAnswer>();
            DataEmployeesLogs = new HashSet<DataEmployeesLog>();
            DataEmployeesReminders = new HashSet<DataEmployeesReminder>();
            DataFeedbackAnswers = new HashSet<DataFeedbackAnswer>();
            DataFeedbackExecutions = new HashSet<DataFeedbackExecution>();
            DataFeedbackQuestions = new HashSet<DataFeedbackQuestion>();
            DataInfoRecipients = new HashSet<DataInfoRecipient>();
            DataInfoViews = new HashSet<DataInfoView>();
            DataInfos = new HashSet<DataInfo>();
            DataNewsViews = new HashSet<DataNewsView>();
            DataPollRegionSms = new HashSet<DataPollRegionSm>();
            DataPremiumFines = new HashSet<DataPremiumFine>();
            DataPremiumSteps = new HashSet<DataPremiumStep>();
            DataRatingExecutedEmployees = new HashSet<DataRatingExecutedEmployee>();
            DataRatingReceivedEmployees = new HashSet<DataRatingReceivedEmployee>();
            DataReportExecuteds = new HashSet<DataReportExecuted>();
            DataReportIasMkguConsents = new HashSet<DataReportIasMkguConsent>();
            DataReportIasMkguInfomats = new HashSet<DataReportIasMkguInfomat>();
            DataReportIasMkguServices = new HashSet<DataReportIasMkguService>();
            DataReportIasMkguSms = new HashSet<DataReportIasMkguSm>();
            DataReportOverdueRoutesStages = new HashSet<DataReportOverdueRoutesStage>();
            DataReportReceiveds = new HashSet<DataReportReceived>();
            DataReportSmevStatistics = new HashSet<DataReportSmevStatistic>();
            DataReportTransferSprEmployees = new HashSet<DataReportTransfer>();
            DataReportTransferSprEmployeesIdNewNavigations = new HashSet<DataReportTransfer>();
            DataReportTransferSprEmployeesIdOldNavigations = new HashSet<DataReportTransfer>();
            DataServiceSprEmployees = new HashSet<DataService>();
            DataServiceSprEmployeesIdExecutionNavigations = new HashSet<DataService>();
            DataServicesCommenttRecipients = new HashSet<DataServicesCommenttRecipient>();
            DataServicesCommentts = new HashSet<DataServicesCommentt>();
            DataServicesCustomerCalls = new HashSet<DataServicesCustomerCall>();
            DataServicesCustomerMessages = new HashSet<DataServicesCustomerMessage>();
            DataServicesFiles = new HashSet<DataServicesFile>();
            DataServicesIncomingSmevRequests = new HashSet<DataServicesIncomingSmevRequest>();
            DataServicesInfoFavorites = new HashSet<DataServicesInfoFavorite>();
            DataServicesPayments = new HashSet<DataServicesPayment>();
            DataServicesRoutesStages = new HashSet<DataServicesRoutesStage>();
            DataServicesSmevRequests = new HashSet<DataServicesSmevRequest>();
            DataServicesViewLogs = new HashSet<DataServicesViewLog>();
            DataTestEmployees = new HashSet<DataTestEmployee>();
            DataTestPrepareds = new HashSet<DataTestPrepared>();
            RefreshTokens = new HashSet<RefreshToken>();
            SprCoverLetterTemplates = new HashSet<SprCoverLetterTemplate>();
            SprEmployeesAuthorizationLogs = new HashSet<SprEmployeesAuthorizationLog>();
            SprEmployeesExecutorRoles = new HashSet<SprEmployeesExecutorRole>();
            SprEmployeesFileFolders = new HashSet<SprEmployeesFileFolder>();
            SprEmployeesMessageTemplates = new HashSet<SprEmployeesMessageTemplate>();
            SprEmployeesMfcCurators = new HashSet<SprEmployeesMfcCurator>();
            SprEmployeesMfcJoins = new HashSet<SprEmployeesMfcJoin>();
            SprEmployeesWorkingTimeJoins = new HashSet<SprEmployeesWorkingTimeJoin>();
            StatisticsClicks = new HashSet<StatisticsClick>();
        }

        public Guid Id { get; set; }
        public string EmployeeFio { get; set; }
        public string EmployeeLogin { get; set; }
        public string EmployeePassHelp { get; set; }
        public string EmployeeTel { get; set; }
        public string EmployeeEmail { get; set; }
        public byte[] EmployeeFoto { get; set; }
        public string EmployeeMnemo { get; set; }
        public string Commentt { get; set; }
        public string EmployeePass { get; set; }
        public DateTime? SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public short? RowDel { get; set; }
        public string CertificateNumber { get; set; }
        public DateTime? EmployeeDocBirthDate { get; set; }
        public string EmployeeDocBirthPlace { get; set; }
        public string EmployeeDocSerial { get; set; }
        public string EmployeeDocNumber { get; set; }
        public DateTime? EmployeeDocIssueDate { get; set; }
        public string EmployeeDocIssueBody { get; set; }
        public string EmployeeDocCode { get; set; }
        public string EmployeeSnils { get; set; }
        public string EmployeeInn { get; set; }
        public DateTime? CountServicesDate { get; set; }
        public short? CountServices { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public int EmployyeSkill { get; set; }
        public string Education { get; set; }
        public string WorkExperience { get; set; }
        public Guid? SprEmployeesMfcRemoteWorkplaceId { get; set; }

        public virtual SprEmployeesMfcRemoteWorkplace SprEmployeesMfcRemoteWorkplace { get; set; }
        public virtual ICollection<ArchiveCoverLetter> ArchiveCoverLetters { get; set; }
        public virtual ICollection<ArchivePremium> ArchivePremia { get; set; }
        public virtual ICollection<ArchivePremiumStep> ArchivePremiumSteps { get; set; }
        public virtual ICollection<ArchiveRatingExecutedEmployee> ArchiveRatingExecutedEmployees { get; set; }
        public virtual ICollection<ArchiveRatingReceivedEmployee> ArchiveRatingReceivedEmployees { get; set; }
        public virtual ICollection<ArchiveService> ArchiveServiceSprEmployees { get; set; }
        public virtual ICollection<ArchiveService> ArchiveServiceSprEmployeesIdExecutionNavigations { get; set; }
        public virtual ICollection<ArchiveServicesCommenttRecipient> ArchiveServicesCommenttRecipients { get; set; }
        public virtual ICollection<ArchiveServicesCommentt> ArchiveServicesCommentts { get; set; }
        public virtual ICollection<ArchiveServicesCustomerCall> ArchiveServicesCustomerCalls { get; set; }
        public virtual ICollection<ArchiveServicesCustomerMessage> ArchiveServicesCustomerMessages { get; set; }
        public virtual ICollection<ArchiveServicesFile> ArchiveServicesFiles { get; set; }
        public virtual ICollection<ArchiveServicesPayment> ArchiveServicesPayments { get; set; }
        public virtual ICollection<ArchiveServicesRoutesStage> ArchiveServicesRoutesStages { get; set; }
        public virtual ICollection<ArchiveServicesSmevRequest> ArchiveServicesSmevRequests { get; set; }
        public virtual ICollection<ArchiveServicesViewLog> ArchiveServicesViewLogs { get; set; }
        public virtual ICollection<DataCallbackCall> DataCallbackCalls { get; set; }
        public virtual ICollection<DataCoverLetter> DataCoverLetters { get; set; }
        public virtual ICollection<DataEmployeesAlert> DataEmployeesAlerts { get; set; }
        public virtual ICollection<DataEmployeesInterviewAnswer> DataEmployeesInterviewAnswers { get; set; }
        public virtual ICollection<DataEmployeesLog> DataEmployeesLogs { get; set; }
        public virtual ICollection<DataEmployeesReminder> DataEmployeesReminders { get; set; }
        public virtual ICollection<DataFeedbackAnswer> DataFeedbackAnswers { get; set; }
        public virtual ICollection<DataFeedbackExecution> DataFeedbackExecutions { get; set; }
        public virtual ICollection<DataFeedbackQuestion> DataFeedbackQuestions { get; set; }
        public virtual ICollection<DataInfoRecipient> DataInfoRecipients { get; set; }
        public virtual ICollection<DataInfoView> DataInfoViews { get; set; }
        public virtual ICollection<DataInfo> DataInfos { get; set; }
        public virtual ICollection<DataNewsView> DataNewsViews { get; set; }
        public virtual ICollection<DataPollRegionSm> DataPollRegionSms { get; set; }
        public virtual ICollection<DataPremiumFine> DataPremiumFines { get; set; }
        public virtual ICollection<DataPremiumStep> DataPremiumSteps { get; set; }
        public virtual ICollection<DataRatingExecutedEmployee> DataRatingExecutedEmployees { get; set; }
        public virtual ICollection<DataRatingReceivedEmployee> DataRatingReceivedEmployees { get; set; }
        public virtual ICollection<DataReportExecuted> DataReportExecuteds { get; set; }
        public virtual ICollection<DataReportIasMkguConsent> DataReportIasMkguConsents { get; set; }
        public virtual ICollection<DataReportIasMkguInfomat> DataReportIasMkguInfomats { get; set; }
        public virtual ICollection<DataReportIasMkguService> DataReportIasMkguServices { get; set; }
        public virtual ICollection<DataReportIasMkguSm> DataReportIasMkguSms { get; set; }
        public virtual ICollection<DataReportOverdueRoutesStage> DataReportOverdueRoutesStages { get; set; }
        public virtual ICollection<DataReportReceived> DataReportReceiveds { get; set; }
        public virtual ICollection<DataReportSmevStatistic> DataReportSmevStatistics { get; set; }
        public virtual ICollection<DataReportTransfer> DataReportTransferSprEmployees { get; set; }
        public virtual ICollection<DataReportTransfer> DataReportTransferSprEmployeesIdNewNavigations { get; set; }
        public virtual ICollection<DataReportTransfer> DataReportTransferSprEmployeesIdOldNavigations { get; set; }
        public virtual ICollection<DataService> DataServiceSprEmployees { get; set; }
        public virtual ICollection<DataService> DataServiceSprEmployeesIdExecutionNavigations { get; set; }
        public virtual ICollection<DataServicesCommenttRecipient> DataServicesCommenttRecipients { get; set; }
        public virtual ICollection<DataServicesCommentt> DataServicesCommentts { get; set; }
        public virtual ICollection<DataServicesCustomerCall> DataServicesCustomerCalls { get; set; }
        public virtual ICollection<DataServicesCustomerMessage> DataServicesCustomerMessages { get; set; }
        public virtual ICollection<DataServicesFile> DataServicesFiles { get; set; }
        public virtual ICollection<DataServicesIncomingSmevRequest> DataServicesIncomingSmevRequests { get; set; }
        public virtual ICollection<DataServicesInfoFavorite> DataServicesInfoFavorites { get; set; }
        public virtual ICollection<DataServicesPayment> DataServicesPayments { get; set; }
        public virtual ICollection<DataServicesRoutesStage> DataServicesRoutesStages { get; set; }
        public virtual ICollection<DataServicesSmevRequest> DataServicesSmevRequests { get; set; }
        public virtual ICollection<DataServicesViewLog> DataServicesViewLogs { get; set; }
        public virtual ICollection<DataTestEmployee> DataTestEmployees { get; set; }
        public virtual ICollection<DataTestPrepared> DataTestPrepareds { get; set; }
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }
        public virtual ICollection<SprCoverLetterTemplate> SprCoverLetterTemplates { get; set; }
        public virtual ICollection<SprEmployeesAuthorizationLog> SprEmployeesAuthorizationLogs { get; set; }
        public virtual ICollection<SprEmployeesExecutorRole> SprEmployeesExecutorRoles { get; set; }
        public virtual ICollection<SprEmployeesFileFolder> SprEmployeesFileFolders { get; set; }
        public virtual ICollection<SprEmployeesMessageTemplate> SprEmployeesMessageTemplates { get; set; }
        public virtual ICollection<SprEmployeesMfcCurator> SprEmployeesMfcCurators { get; set; }
        public virtual ICollection<SprEmployeesMfcJoin> SprEmployeesMfcJoins { get; set; }
        public virtual ICollection<SprEmployeesWorkingTimeJoin> SprEmployeesWorkingTimeJoins { get; set; }
        public virtual ICollection<StatisticsClick> StatisticsClicks { get; set; }
    }
}
