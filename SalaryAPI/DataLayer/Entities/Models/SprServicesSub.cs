using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSub
    {
        public SprServicesSub()
        {
            ArchivePremiumFineSums = new HashSet<ArchivePremiumFineSum>();
            ArchivePremiumStepServices = new HashSet<ArchivePremiumStepService>();
            ArchivePremiumSteps = new HashSet<ArchivePremiumStep>();
            DataPremiumFines = new HashSet<DataPremiumFine>();
            DataReportExecuteds = new HashSet<DataReportExecuted>();
            DataReportOverdueRoutesStages = new HashSet<DataReportOverdueRoutesStage>();
            DataReportReceiveds = new HashSet<DataReportReceived>();
            DataServices = new HashSet<DataService>();
            DataServicesRatings = new HashSet<DataServicesRating>();
            SprServicesForms = new HashSet<SprServicesForm>();
            SprServicesSubActives = new HashSet<SprServicesSubActive>();
            SprServicesSubCustomers = new HashSet<SprServicesSubCustomer>();
            SprServicesSubDocuments = new HashSet<SprServicesSubDocument>();
            SprServicesSubExecutorRoles = new HashSet<SprServicesSubExecutorRole>();
            SprServicesSubFailureDocs = new HashSet<SprServicesSubFailureDoc>();
            SprServicesSubFailures = new HashSet<SprServicesSubFailure>();
            SprServicesSubFileFolders = new HashSet<SprServicesSubFileFolder>();
            SprServicesSubGroupParametrsJoins = new HashSet<SprServicesSubGroupParametrsJoin>();
            SprServicesSubLivingSituationsJoins = new HashSet<SprServicesSubLivingSituationsJoin>();
            SprServicesSubParametrs = new HashSet<SprServicesSubParametr>();
            SprServicesSubPremia = new HashSet<SprServicesSubPremium>();
            SprServicesSubResultDocs = new HashSet<SprServicesSubResultDoc>();
            SprServicesSubSmevRequestJoins = new HashSet<SprServicesSubSmevRequestJoin>();
            SprServicesSubStateTasks = new HashSet<SprServicesSubStateTask>();
            SprServicesSubStops = new HashSet<SprServicesSubStop>();
            SprServicesSubTypeQualityJoins = new HashSet<SprServicesSubTypeQualityJoin>();
            SprServicesSubWayGetJoins = new HashSet<SprServicesSubWayGetJoin>();
            SprServicesSubWayGetResultJoins = new HashSet<SprServicesSubWayGetResultJoin>();
        }

        public Guid Id { get; set; }
        public Guid SprServicesId { get; set; }
        public string ServiceSubMnemo { get; set; }
        public string ServiceSubName { get; set; }
        public string ServiceSubNameSmall { get; set; }
        public string Commentt { get; set; }
        public string FrguTargetId { get; set; }
        public string ServiceSubDescription { get; set; }
        public string EpguIdForm { get; set; }
        public string LegalAct { get; set; }
        public string KbkPayment { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public string FrguTargetName { get; set; }
        public bool? ReportSelect { get; set; }
        public bool? TariffEdit { get; set; }
        public bool? IasMkgu { get; set; }
        public Guid SprServicesProviderId { get; set; }
        public short? ServiceSubPosition { get; set; }
        public short? RowDel { get; set; }
        public string AlertText { get; set; }
        public Guid? MdmUuid { get; set; }
        public string FrguServicesSubId { get; set; }
        public string Hashtag { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public string CodeCheckmaster { get; set; }
        public string Purpose { get; set; }
        public int LevelDifficulty { get; set; }
        public string FrguProcedureId { get; set; }
        public string ServiceSubParametrsJson { get; set; }
        public string CodeCheckmasterForMfc { get; set; }
        public bool IsUinRequired { get; set; }
        public bool IsCalculatesStatistics { get; set; }

        public virtual SprService SprServices { get; set; }
        public virtual SprServicesProvider SprServicesProvider { get; set; }
        public virtual SprServicesSubCommercial SprServicesSubCommercial { get; set; }
        public virtual SprServicesSubSurveying SprServicesSubSurveying { get; set; }
        public virtual ICollection<ArchivePremiumFineSum> ArchivePremiumFineSums { get; set; }
        public virtual ICollection<ArchivePremiumStepService> ArchivePremiumStepServices { get; set; }
        public virtual ICollection<ArchivePremiumStep> ArchivePremiumSteps { get; set; }
        public virtual ICollection<DataPremiumFine> DataPremiumFines { get; set; }
        public virtual ICollection<DataReportExecuted> DataReportExecuteds { get; set; }
        public virtual ICollection<DataReportOverdueRoutesStage> DataReportOverdueRoutesStages { get; set; }
        public virtual ICollection<DataReportReceived> DataReportReceiveds { get; set; }
        public virtual ICollection<DataService> DataServices { get; set; }
        public virtual ICollection<DataServicesRating> DataServicesRatings { get; set; }
        public virtual ICollection<SprServicesForm> SprServicesForms { get; set; }
        public virtual ICollection<SprServicesSubActive> SprServicesSubActives { get; set; }
        public virtual ICollection<SprServicesSubCustomer> SprServicesSubCustomers { get; set; }
        public virtual ICollection<SprServicesSubDocument> SprServicesSubDocuments { get; set; }
        public virtual ICollection<SprServicesSubExecutorRole> SprServicesSubExecutorRoles { get; set; }
        public virtual ICollection<SprServicesSubFailureDoc> SprServicesSubFailureDocs { get; set; }
        public virtual ICollection<SprServicesSubFailure> SprServicesSubFailures { get; set; }
        public virtual ICollection<SprServicesSubFileFolder> SprServicesSubFileFolders { get; set; }
        public virtual ICollection<SprServicesSubGroupParametrsJoin> SprServicesSubGroupParametrsJoins { get; set; }
        public virtual ICollection<SprServicesSubLivingSituationsJoin> SprServicesSubLivingSituationsJoins { get; set; }
        public virtual ICollection<SprServicesSubParametr> SprServicesSubParametrs { get; set; }
        public virtual ICollection<SprServicesSubPremium> SprServicesSubPremia { get; set; }
        public virtual ICollection<SprServicesSubResultDoc> SprServicesSubResultDocs { get; set; }
        public virtual ICollection<SprServicesSubSmevRequestJoin> SprServicesSubSmevRequestJoins { get; set; }
        public virtual ICollection<SprServicesSubStateTask> SprServicesSubStateTasks { get; set; }
        public virtual ICollection<SprServicesSubStop> SprServicesSubStops { get; set; }
        public virtual ICollection<SprServicesSubTypeQualityJoin> SprServicesSubTypeQualityJoins { get; set; }
        public virtual ICollection<SprServicesSubWayGetJoin> SprServicesSubWayGetJoins { get; set; }
        public virtual ICollection<SprServicesSubWayGetResultJoin> SprServicesSubWayGetResultJoins { get; set; }
    }
}
