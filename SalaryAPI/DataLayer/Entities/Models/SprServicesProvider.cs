using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesProvider
    {
        public SprServicesProvider()
        {
            DataReportExecuteds = new HashSet<DataReportExecuted>();
            DataReportOverdueRoutesStages = new HashSet<DataReportOverdueRoutesStage>();
            DataReportReceiveds = new HashSet<DataReportReceived>();
            SprServicesProviderDepartments = new HashSet<SprServicesProviderDepartment>();
            SprServicesProviderMfcs = new HashSet<SprServicesProviderMfc>();
            SprServicesProviderRecipientPayments = new HashSet<SprServicesProviderRecipientPayment>();
            SprServicesSubs = new HashSet<SprServicesSub>();
        }

        public Guid Id { get; set; }
        public string ProviderMnemo { get; set; }
        public string ProviderName { get; set; }
        public string ProviderNameSmall { get; set; }
        public string ProviderAddress { get; set; }
        public string ProviderDirector { get; set; }
        public string ProviderTel { get; set; }
        public string ProviderEmail { get; set; }
        public byte[] ProviderLogo { get; set; }
        public string ProviderWebsite { get; set; }
        public string Commentt { get; set; }
        public string FrguProviderId { get; set; }
        public string FrguProviderName { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public short? RowDel { get; set; }
        public string WorkShedule { get; set; }
        public string ProviderFax { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }

        public virtual ICollection<DataReportExecuted> DataReportExecuteds { get; set; }
        public virtual ICollection<DataReportOverdueRoutesStage> DataReportOverdueRoutesStages { get; set; }
        public virtual ICollection<DataReportReceived> DataReportReceiveds { get; set; }
        public virtual ICollection<SprServicesProviderDepartment> SprServicesProviderDepartments { get; set; }
        public virtual ICollection<SprServicesProviderMfc> SprServicesProviderMfcs { get; set; }
        public virtual ICollection<SprServicesProviderRecipientPayment> SprServicesProviderRecipientPayments { get; set; }
        public virtual ICollection<SprServicesSub> SprServicesSubs { get; set; }
    }
}
