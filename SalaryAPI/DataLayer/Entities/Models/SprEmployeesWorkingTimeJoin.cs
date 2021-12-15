using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprEmployeesWorkingTimeJoin
    {
        public Guid Id { get; set; }
        public Guid? SprEmployeesId { get; set; }
        public DateTime Date { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public int SprEmployeesWorkingTimeId { get; set; }
        public string SprEmployeesJobPosName { get; set; }
        public int? SprEmployeesJobPosId { get; set; }
        public Guid? SprEmployeesMfcJoinId { get; set; }
        public Guid? SprEmployeesSalaryId { get; set; }
        public Guid? SprEmployeesMfcId { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }

        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprEmployeesWorkingTime SprEmployeesWorkingTime { get; set; }
    }
}
