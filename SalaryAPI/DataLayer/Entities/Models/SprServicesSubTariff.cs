using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSubTariff
    {
        public Guid Id { get; set; }
        public Guid SprServicesSubCustomerId { get; set; }
        public short CountDayProcessing { get; set; }
        public short CountDayExecution { get; set; }
        public short SprServicesSubWeekId { get; set; }
        public short CountDayReturn { get; set; }
        public decimal Tariff { get; set; }
        public short? RowDel { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public string Commentt { get; set; }
        public int? SprServicesSubTariffTypeId { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public decimal? TariffMfc { get; set; }

        public virtual SprServicesSubCustomer SprServicesSubCustomer { get; set; }
        public virtual SprServicesSubWeek SprServicesSubWeek { get; set; }
    }
}
