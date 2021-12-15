using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataServicesInfo
    {
        public DataServicesInfo()
        {
            DataEmployeesAlerts = new HashSet<DataEmployeesAlert>();
            DataEmployeesReminders = new HashSet<DataEmployeesReminder>();
            DataPollRegionSms = new HashSet<DataPollRegionSm>();
            DataServices = new HashSet<DataService>();
            DataServicesCommentts = new HashSet<DataServicesCommentt>();
            DataServicesCustomerCalls = new HashSet<DataServicesCustomerCall>();
            DataServicesCustomerMessages = new HashSet<DataServicesCustomerMessage>();
            DataServicesCustomers = new HashSet<DataServicesCustomer>();
            DataServicesDocuments = new HashSet<DataServicesDocument>();
            DataServicesElplats = new HashSet<DataServicesElplat>();
            DataServicesFileResults = new HashSet<DataServicesFileResult>();
            DataServicesFiles = new HashSet<DataServicesFile>();
            DataServicesIncomingSmevRequests = new HashSet<DataServicesIncomingSmevRequest>();
            DataServicesInfoFavorites = new HashSet<DataServicesInfoFavorite>();
            DataServicesParametr1s = new HashSet<DataServicesParametr1>();
            DataServicesParametrs = new HashSet<DataServicesParametr>();
            DataServicesPayments = new HashSet<DataServicesPayment>();
            DataServicesRoutesStages = new HashSet<DataServicesRoutesStage>();
            DataServicesSmevRequests = new HashSet<DataServicesSmevRequest>();
            DataServicesViewLogs = new HashSet<DataServicesViewLog>();
        }

        public string Id { get; set; }
        public string Commentt { get; set; }
        public bool? ServicesStart { get; set; }
        public DateTime SetDate { get; set; }
        public DateTime? DateFinishTotal { get; set; }
        public Guid? SprEmployeesMfcRemoteWorkplaceId { get; set; }
        public short? SmsRating { get; set; }
        public string NumberTicketQueue { get; set; }
        public DateTime? DateAdd { get; set; }

        public virtual ICollection<DataEmployeesAlert> DataEmployeesAlerts { get; set; }
        public virtual ICollection<DataEmployeesReminder> DataEmployeesReminders { get; set; }
        public virtual ICollection<DataPollRegionSm> DataPollRegionSms { get; set; }
        public virtual ICollection<DataService> DataServices { get; set; }
        public virtual ICollection<DataServicesCommentt> DataServicesCommentts { get; set; }
        public virtual ICollection<DataServicesCustomerCall> DataServicesCustomerCalls { get; set; }
        public virtual ICollection<DataServicesCustomerMessage> DataServicesCustomerMessages { get; set; }
        public virtual ICollection<DataServicesCustomer> DataServicesCustomers { get; set; }
        public virtual ICollection<DataServicesDocument> DataServicesDocuments { get; set; }
        public virtual ICollection<DataServicesElplat> DataServicesElplats { get; set; }
        public virtual ICollection<DataServicesFileResult> DataServicesFileResults { get; set; }
        public virtual ICollection<DataServicesFile> DataServicesFiles { get; set; }
        public virtual ICollection<DataServicesIncomingSmevRequest> DataServicesIncomingSmevRequests { get; set; }
        public virtual ICollection<DataServicesInfoFavorite> DataServicesInfoFavorites { get; set; }
        public virtual ICollection<DataServicesParametr1> DataServicesParametr1s { get; set; }
        public virtual ICollection<DataServicesParametr> DataServicesParametrs { get; set; }
        public virtual ICollection<DataServicesPayment> DataServicesPayments { get; set; }
        public virtual ICollection<DataServicesRoutesStage> DataServicesRoutesStages { get; set; }
        public virtual ICollection<DataServicesSmevRequest> DataServicesSmevRequests { get; set; }
        public virtual ICollection<DataServicesViewLog> DataServicesViewLogs { get; set; }
    }
}
