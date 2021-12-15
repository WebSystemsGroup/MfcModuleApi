using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataPremiumFine
    {
        public Guid Id { get; set; }
        public Guid SprEmployeesId { get; set; }
        public DateTime DateFine { get; set; }
        public decimal FinePercent { get; set; }
        public int SprEmployeesJobPosId { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public decimal FineSum { get; set; }
        public Guid SprServicesSubId { get; set; }
        public string DataServicesInfoId { get; set; }
        public int SprRoutesStageId { get; set; }
        public short? RowDel { get; set; }
        public string EmployeesFioDel { get; set; }
        public string CommenttDel { get; set; }
        public DateTime? DateDel { get; set; }

        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprEmployeesJobPo SprEmployeesJobPos { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual SprRoutesStage SprRoutesStage { get; set; }
        public virtual SprServicesSub SprServicesSub { get; set; }
    }
}
