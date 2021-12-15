using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprEmployeesMfc
    {
        public SprEmployeesMfc()
        {
            ApiManagerPanelQueueInfos = new HashSet<ApiManagerPanelQueueInfo>();
            ApiManagerPanelStateTasks = new HashSet<ApiManagerPanelStateTask>();
            ApiManagerPanelServicePeriods = new HashSet<ApiManagerPanelServicePeriod>();
            ArchiveForSearches = new HashSet<ArchiveForSearch>();
            ArchivePremia = new HashSet<ArchivePremium>();
            ArchivePremiumSteps = new HashSet<ArchivePremiumStep>();
            ArchiveRatingExecutedEmployeesMfcs = new HashSet<ArchiveRatingExecutedEmployeesMfc>();
            ArchiveRatingReceivedEmployeesMfcs = new HashSet<ArchiveRatingReceivedEmployeesMfc>();
            ArchiveServiceSprEmployeesMfcIdExecutionNavigations = new HashSet<ArchiveService>();
            ArchiveServiceSprEmployeesMfcs = new HashSet<ArchiveService>();
            ArchiveServicesCustomerCalls = new HashSet<ArchiveServicesCustomerCall>();
            ArchiveServicesFileResults = new HashSet<ArchiveServicesFileResult>();
            ArchiveServicesRoutesStages = new HashSet<ArchiveServicesRoutesStage>();
            DataCallbackCalls = new HashSet<DataCallbackCall>();
            DataCallbacks = new HashSet<DataCallback>();
            DataEmployeesMfcIasMkguOurs = new HashSet<DataEmployeesMfcIasMkguOur>();
            DataEmployeesMfcIasMkguWebsites = new HashSet<DataEmployeesMfcIasMkguWebsite>();
            DataIncomingCalls = new HashSet<DataIncomingCall>();
            DataNewsRecipients = new HashSet<DataNewsRecipient>();
            DataPollRegionSms = new HashSet<DataPollRegionSm>();
            DataPremiumFines = new HashSet<DataPremiumFine>();
            DataQueueAvgTimes = new HashSet<DataQueueAvgTime>();
            DataRatingExecutedEmployeesMfcs = new HashSet<DataRatingExecutedEmployeesMfc>();
            DataRatingReceivedEmployeesMfcs = new HashSet<DataRatingReceivedEmployeesMfc>();
            DataReportExecuteds = new HashSet<DataReportExecuted>();
            DataReportIasMkguConsents = new HashSet<DataReportIasMkguConsent>();
            DataReportIasMkguInfomats = new HashSet<DataReportIasMkguInfomat>();
            DataReportIasMkguServices = new HashSet<DataReportIasMkguService>();
            DataReportIasMkguSms = new HashSet<DataReportIasMkguSm>();
            DataReportOverdueRoutesStages = new HashSet<DataReportOverdueRoutesStage>();
            DataReportReceiveds = new HashSet<DataReportReceived>();
            DataReportSmevStatistics = new HashSet<DataReportSmevStatistic>();
            DataReportTransfers = new HashSet<DataReportTransfer>();
            DataServiceSprEmployeesMfcIdExecutionNavigations = new HashSet<DataService>();
            DataServiceSprEmployeesMfcs = new HashSet<DataService>();
            DataServicesCustomerCalls = new HashSet<DataServicesCustomerCall>();
            DataServicesFileResults = new HashSet<DataServicesFileResult>();
            DataServicesRatings = new HashSet<DataServicesRating>();
            DataServicesRoutesStages = new HashSet<DataServicesRoutesStage>();
            DataTestQuestionEmployees = new HashSet<DataTestQuestionEmployee>();
            DataTests = new HashSet<DataTest>();
            SprEmployeesMfcCurators = new HashSet<SprEmployeesMfcCurator>();
            SprEmployeesMfcFtpJoins = new HashSet<SprEmployeesMfcFtpJoin>();
            SprEmployeesMfcJoins = new HashSet<SprEmployeesMfcJoin>();
            SprEmployeesMfcRemoteWorkplaces = new HashSet<SprEmployeesMfcRemoteWorkplace>();
            SprMfcZags = new HashSet<SprMfcZag>();
            SprQueueJoinMfcs = new HashSet<SprQueueJoinMfc>();
            SprServicesProviderMfcs = new HashSet<SprServicesProviderMfc>();
            SprServicesSubActives = new HashSet<SprServicesSubActive>();
            SprServicesSubExecutorRoles = new HashSet<SprServicesSubExecutorRole>();
            StatisticsClicks = new HashSet<StatisticsClick>();
        }

        public Guid Id { get; set; }
        public string MfcMnemo { get; set; }
        public string MfcName { get; set; }
        public string MfcNameSmall { get; set; }
        public string MfcAddress { get; set; }
        public string MfcTel { get; set; }
        public string MfcWebsite { get; set; }
        public string MfcInn { get; set; }
        public string MfcOgrn { get; set; }
        public string MfcOktmo { get; set; }
        public byte[] MfcLogo { get; set; }
        public string MfcEmail { get; set; }
        public string MfcEmailLogin { get; set; }
        public string MfcEmailPass { get; set; }
        public string MfcEmailServer { get; set; }
        public string MfcEmailPort { get; set; }
        public string MfcCallServer { get; set; }
        public int? MfcCountPopulation { get; set; }
        public string MfcEsiaCentrId { get; set; }
        public string MfcNum { get; set; }
        public string MfcNumPfr { get; set; }
        public short? MfcCountWindows { get; set; }
        public string Commentt { get; set; }
        public DateTime? SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public int? MfcVendorId { get; set; }
        public string MfcOkato { get; set; }
        public string PfrMnemo { get; set; }
        public string PfrMnemoMfc { get; set; }
        public int? QueueId { get; set; }
        public bool? HeadOperatorHall { get; set; }
        public string MfcKpp { get; set; }
        public bool? StructuralSubdivision { get; set; }
        public string MfcLogoName { get; set; }
        public string MdmUid { get; set; }
        public string GeographicCoordinate { get; set; }
        public string MfcSkype { get; set; }
        public string MfcSchedule { get; set; }
        public string MfcTosp { get; set; }
        public string MfcEpguId { get; set; }
        public string MfcConvenience { get; set; }
        public string MfcCikId { get; set; }
        public string MfcCikName { get; set; }
        public string MfcUrlQueueImage { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }
        public int MinTrudRequestNum { get; set; }
        public string EsiaOperatorSnils { get; set; }
        public int? Number { get; set; }
        public string MfcEpguSmevId { get; set; }
        public bool IsCallbackActive { get; set; }
        public string QueueIp { get; set; }
        public string MfcFrguId { get; set; }
        public string MvdOpvMfcId { get; set; }
        public string MfcHeadName { get; set; }
        public string MegalabsLogin { get; set; }
        public string MegalabsPassword { get; set; }
        public string MegalabsSender { get; set; }
        public int? SprEmployeesMfcTypeId { get; set; }

        public virtual SprEmployeesMfcType SprEmployeesMfcType { get; set; }
        public virtual ICollection<ApiManagerPanelQueueInfo> ApiManagerPanelQueueInfos { get; set; }
        public virtual ICollection<ApiManagerPanelStateTask> ApiManagerPanelStateTasks { get; set; }
        public virtual ICollection<ApiManagerPanelServicePeriod> ApiManagerPanelServicePeriods { get; set; }
        public virtual ICollection<ArchiveForSearch> ArchiveForSearches { get; set; }
        public virtual ICollection<ArchivePremium> ArchivePremia { get; set; }
        public virtual ICollection<ArchivePremiumStep> ArchivePremiumSteps { get; set; }
        public virtual ICollection<ArchiveRatingExecutedEmployeesMfc> ArchiveRatingExecutedEmployeesMfcs { get; set; }
        public virtual ICollection<ArchiveRatingReceivedEmployeesMfc> ArchiveRatingReceivedEmployeesMfcs { get; set; }
        public virtual ICollection<ArchiveService> ArchiveServiceSprEmployeesMfcIdExecutionNavigations { get; set; }
        public virtual ICollection<ArchiveService> ArchiveServiceSprEmployeesMfcs { get; set; }
        public virtual ICollection<ArchiveServicesCustomerCall> ArchiveServicesCustomerCalls { get; set; }
        public virtual ICollection<ArchiveServicesFileResult> ArchiveServicesFileResults { get; set; }
        public virtual ICollection<ArchiveServicesRoutesStage> ArchiveServicesRoutesStages { get; set; }
        public virtual ICollection<DataCallbackCall> DataCallbackCalls { get; set; }
        public virtual ICollection<DataCallback> DataCallbacks { get; set; }
        public virtual ICollection<DataEmployeesMfcIasMkguOur> DataEmployeesMfcIasMkguOurs { get; set; }
        public virtual ICollection<DataEmployeesMfcIasMkguWebsite> DataEmployeesMfcIasMkguWebsites { get; set; }
        public virtual ICollection<DataIncomingCall> DataIncomingCalls { get; set; }
        public virtual ICollection<DataNewsRecipient> DataNewsRecipients { get; set; }
        public virtual ICollection<DataPollRegionSm> DataPollRegionSms { get; set; }
        public virtual ICollection<DataPremiumFine> DataPremiumFines { get; set; }
        public virtual ICollection<DataQueueAvgTime> DataQueueAvgTimes { get; set; }
        public virtual ICollection<DataRatingExecutedEmployeesMfc> DataRatingExecutedEmployeesMfcs { get; set; }
        public virtual ICollection<DataRatingReceivedEmployeesMfc> DataRatingReceivedEmployeesMfcs { get; set; }
        public virtual ICollection<DataReportExecuted> DataReportExecuteds { get; set; }
        public virtual ICollection<DataReportIasMkguConsent> DataReportIasMkguConsents { get; set; }
        public virtual ICollection<DataReportIasMkguInfomat> DataReportIasMkguInfomats { get; set; }
        public virtual ICollection<DataReportIasMkguService> DataReportIasMkguServices { get; set; }
        public virtual ICollection<DataReportIasMkguSm> DataReportIasMkguSms { get; set; }
        public virtual ICollection<DataReportOverdueRoutesStage> DataReportOverdueRoutesStages { get; set; }
        public virtual ICollection<DataReportReceived> DataReportReceiveds { get; set; }
        public virtual ICollection<DataReportSmevStatistic> DataReportSmevStatistics { get; set; }
        public virtual ICollection<DataReportTransfer> DataReportTransfers { get; set; }
        public virtual ICollection<DataService> DataServiceSprEmployeesMfcIdExecutionNavigations { get; set; }
        public virtual ICollection<DataService> DataServiceSprEmployeesMfcs { get; set; }
        public virtual ICollection<DataServicesCustomerCall> DataServicesCustomerCalls { get; set; }
        public virtual ICollection<DataServicesFileResult> DataServicesFileResults { get; set; }
        public virtual ICollection<DataServicesRating> DataServicesRatings { get; set; }
        public virtual ICollection<DataServicesRoutesStage> DataServicesRoutesStages { get; set; }
        public virtual ICollection<DataTestQuestionEmployee> DataTestQuestionEmployees { get; set; }
        public virtual ICollection<DataTest> DataTests { get; set; }
        public virtual ICollection<SprEmployeesMfcCurator> SprEmployeesMfcCurators { get; set; }
        public virtual ICollection<SprEmployeesMfcFtpJoin> SprEmployeesMfcFtpJoins { get; set; }
        public virtual ICollection<SprEmployeesMfcJoin> SprEmployeesMfcJoins { get; set; }
        public virtual ICollection<SprEmployeesMfcRemoteWorkplace> SprEmployeesMfcRemoteWorkplaces { get; set; }
        public virtual ICollection<SprMfcZag> SprMfcZags { get; set; }
        public virtual ICollection<SprQueueJoinMfc> SprQueueJoinMfcs { get; set; }
        public virtual ICollection<SprServicesProviderMfc> SprServicesProviderMfcs { get; set; }
        public virtual ICollection<SprServicesSubActive> SprServicesSubActives { get; set; }
        public virtual ICollection<SprServicesSubExecutorRole> SprServicesSubExecutorRoles { get; set; }
        public virtual ICollection<StatisticsClick> StatisticsClicks { get; set; }
    }
}
