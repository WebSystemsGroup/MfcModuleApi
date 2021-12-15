using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataReportReceived
    {
        public Guid Id { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public Guid SprServicesProviderId { get; set; }
        public Guid SprServicesSubId { get; set; }
        public string ServiceProviderName { get; set; }
        public string ServiceName { get; set; }
        public string EmployeesFio { get; set; }
        public string EmployeesMfcName { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public short PeriodYear { get; set; }
        public short PeriodMonth { get; set; }
        public short PeriodQuarter { get; set; }
        public short PeriodYearHalf { get; set; }
        public decimal TariffState { get; set; }
        public decimal PriceState { get; set; }
        public int? SprServicesSubTrId { get; set; }
        public int? SprServicesSubTariffTypeId { get; set; }
        public int? SprEmployeesJobPosId { get; set; }
        public string EmployeesJobPosName { get; set; }
        public decimal? TariffMfc { get; set; }

        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual SprServicesProvider SprServicesProvider { get; set; }
        public virtual SprServicesSub SprServicesSub { get; set; }
    }
}
