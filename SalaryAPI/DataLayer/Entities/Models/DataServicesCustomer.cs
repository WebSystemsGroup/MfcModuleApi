using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataServicesCustomer
    {
        public DataServicesCustomer()
        {
            DataServicesCustomerGisgmps = new HashSet<DataServicesCustomerGisgmp>();
            DataServicesPayments = new HashSet<DataServicesPayment>();
        }

        public Guid Id { get; set; }
        public Guid DataServicesId { get; set; }
        public int? SprDocumentIdentityId { get; set; }
        public string DocumentSerial { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime? DocumentBirthDate { get; set; }
        public string DocumentBirthPlace { get; set; }
        public DateTime? DocumentIssueDate { get; set; }
        public string DocumentIssueBody { get; set; }
        public string DocumentCode { get; set; }
        public string CustomerInn { get; set; }
        public string CustomerTel1 { get; set; }
        public string CustomerTel2 { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerAddressOkato { get; set; }
        public string CustomerOktmo { get; set; }
        public string CustomerCodeRegion { get; set; }
        public string CustomerKppLegal { get; set; }
        public string CustomerOgrnLegal { get; set; }
        public int SprServicesSubTrId { get; set; }
        public string Commentt { get; set; }
        public string DataServicesInfoId { get; set; }
        public string CustomerSex { get; set; }
        public string CustomerSnils { get; set; }
        public DateTime? SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public string CustomerNameLegal { get; set; }
        public string CustomerInnLegal { get; set; }
        public string CustomerFio { get; set; }
        public short? CustomerType { get; set; }
        public bool? PollRegionSms { get; set; }
        public short? PollIasMkgu { get; set; }
        public int? SprAlertId { get; set; }
        public string CustomerNameDirector { get; set; }
        public string CustomerDirectorJob { get; set; }
        public Guid? SprEmployeesId { get; set; }
        public int? SprEmployeesJobPosId { get; set; }
        public string EmployeesJobPosName { get; set; }
        public string EmployeesMfcName { get; set; }
        public Guid? SprEmployeesMfcId { get; set; }
        public string EmployeesFio { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }
        public string CustomerAddressJson { get; set; }
        public string RelationDegree { get; set; }

        public virtual DataService DataServices { get; set; }
        public virtual DataServicesInfo DataServicesInfo { get; set; }
        public virtual SprServicesSubTypeRecipient SprServicesSubTr { get; set; }
        public virtual ICollection<DataServicesCustomerGisgmp> DataServicesCustomerGisgmps { get; set; }
        public virtual ICollection<DataServicesPayment> DataServicesPayments { get; set; }
    }
}
