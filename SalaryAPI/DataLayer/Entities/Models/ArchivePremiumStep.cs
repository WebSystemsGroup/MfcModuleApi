using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchivePremiumStep
    {
        public Guid Id { get; set; }
        public Guid SprEmployeesId { get; set; }
        public int SprEmployeesJobPosId { get; set; }
        public short StepId { get; set; }
        public DateTime DateStep { get; set; }
        public decimal StepPremium { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public Guid SprServicesSubId { get; set; }
        public string DataServicesInfoId { get; set; }
        public string ServiceName { get; set; }
        public string EmployeesFio { get; set; }
        public string EmployeesJobPosName { get; set; }
        public short? RowDel { get; set; }
        public DateTime? DateModify { get; set; }
        public string CommenttModify { get; set; }

        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprEmployeesJobPo SprEmployeesJobPos { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual SprServicesSub SprServicesSub { get; set; }
    }
}
