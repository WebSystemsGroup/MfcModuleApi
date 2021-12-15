using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataReportSmev
    {
        public Guid Id { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public DateTime Date { get; set; }
        public short PeriodMonth { get; set; }
        public short PeriodYear { get; set; }
        public short PeriodQuarter { get; set; }
        public short PeriodYearHalf { get; set; }
        public string EmployeesFio { get; set; }
        public string EmployeesMfcName { get; set; }
        public int CountSmev { get; set; }
        public Guid SprSmevId { get; set; }
        public string SmevName { get; set; }
    }
}
