using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataSalaryRecalcLog
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateStop { get; set; }
        public string EmployeesFio { get; set; }
        public string Commentt { get; set; }
        public string EmployeesMfcName { get; set; }
        public DateTime? DateFinish { get; set; }
    }
}
