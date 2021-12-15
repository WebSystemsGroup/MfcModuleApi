using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSubSurveying
    {
        public Guid Id { get; set; }
        public Guid SprServicesSubId { get; set; }
        public decimal RecDirector38 { get; set; }
        public decimal RecDirector1040 { get; set; }
        public decimal RecDeputyDirector1040 { get; set; }
        public decimal RecOperator { get; set; }
        public decimal RecOperatorTosp { get; set; }
        public decimal ExecOperator { get; set; }
        public decimal ExecOperatorTosp { get; set; }
        public decimal RecUniversalSpecialist { get; set; }
        public decimal ExecUniversalSpecialist { get; set; }
        public decimal RecSpecialist { get; set; }
        public decimal ExecSpecialist { get; set; }
        public string SetEmployeesFio { get; set; }
        public DateTime SetDate { get; set; }
        public decimal? CourierSurveying { get; set; }
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
