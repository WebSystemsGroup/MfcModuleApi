using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataServicesCustomerMessage
    {
        public Guid Id { get; set; }
        public string DataServicesInfoId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public string EmployeesFio { get; set; }
        public string CustomerName { get; set; }
        public DateTime DateMessage { get; set; }
        public string CustomerTel { get; set; }
        public Guid DataServicesId { get; set; }
        public string TextMessage { get; set; }
        public string EmployeesMfcName { get; set; }
        public string EmployeesJobPosName { get; set; }
        public int? SprEmployeesJobPosId { get; set; }
        public Guid? SprEmployeesMfcId { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }
        public int? IdSms { get; set; }
        public int? Status { get; set; }

        public virtual DataService DataServices { get; set; }
        public virtual DataServicesInfo DataServicesInfo { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
    }
}
