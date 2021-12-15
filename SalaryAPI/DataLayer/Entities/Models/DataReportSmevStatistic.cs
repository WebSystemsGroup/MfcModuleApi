using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataReportSmevStatistic
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Guid SprEmployeesId { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public int SprSmevRequestId { get; set; }
        public string RequestName { get; set; }
        public string EmployeesFio { get; set; }
        public string EmployeesMfcName { get; set; }
        public int? Count { get; set; }
        public int? Status { get; set; }
        public short PeriodMonth { get; set; }
        public short PeriodYear { get; set; }
        public short PeriodQuarter { get; set; }
        public short PeriodYearHalf { get; set; }
        public Guid SprSmevId { get; set; }
        public string SmevName { get; set; }

        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual SprSmevRequest SprSmevRequest { get; set; }
    }
}
