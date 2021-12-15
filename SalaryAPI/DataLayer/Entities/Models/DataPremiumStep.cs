using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataPremiumStep
    {
        public Guid Id { get; set; }
        public Guid SprEmployeesId { get; set; }
        public int SprEmployeesJobPosId { get; set; }
        public short StepId { get; set; }
        public DateTime DateStep { get; set; }
        public decimal StepPremium { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public Guid SprServicesSubId { get; set; }
        public short? R { get; set; }
        public string DataServicesInfoId { get; set; }
        public short? RowDel { get; set; }
        public DateTime? DateModify { get; set; }
        public string CommenttModify { get; set; }
        public Guid? DataServicesId { get; set; }

        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprEmployeesJobPo SprEmployeesJobPos { get; set; }
    }
}
