using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSubCommercial
    {
        public Guid Id { get; set; }
        public Guid SprServicesSubId { get; set; }
        public decimal? PercentReceived { get; set; }
        public decimal? PercentDirector11 { get; set; }
        public decimal? PercentDirector1240 { get; set; }
        public decimal? PercentDeputyDirector1240 { get; set; }
        public decimal? PercentHeadOperatorHall { get; set; }
        public decimal? PercentExecuted { get; set; }
        public string SetEmployeesFio { get; set; }
        public DateTime SetDate { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }

        public virtual SprServicesSub SprServicesSub { get; set; }
    }
}
