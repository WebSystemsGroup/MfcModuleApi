using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataTest
    {
        public DataTest()
        {
            DataEmployeesAlerts = new HashSet<DataEmployeesAlert>();
            DataTestDirections = new HashSet<DataTestDirection>();
            DataTestEmployees = new HashSet<DataTestEmployee>();
            DataTestPrepareds = new HashSet<DataTestPrepared>();
            DataTestQuestions = new HashSet<DataTestQuestion>();
        }

        public Guid Id { get; set; }
        public int TestNumber { get; set; }
        public string TestName { get; set; }
        public int CountQuestion { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public bool? IsRemove { get; set; }
        public Guid? SprEmployeesMfcId { get; set; }
        public int? SprEmployeesJobPosId { get; set; }
        public short? TestType { get; set; }
        public int TestTime { get; set; }
        public DateTime? DateStartTest { get; set; }

        public virtual SprEmployeesJobPo SprEmployeesJobPos { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual ICollection<DataEmployeesAlert> DataEmployeesAlerts { get; set; }
        public virtual ICollection<DataTestDirection> DataTestDirections { get; set; }
        public virtual ICollection<DataTestEmployee> DataTestEmployees { get; set; }
        public virtual ICollection<DataTestPrepared> DataTestPrepareds { get; set; }
        public virtual ICollection<DataTestQuestion> DataTestQuestions { get; set; }
    }
}
