using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprEmployeesMfcJoin
    {
        public SprEmployeesMfcJoin()
        {
            SprEmployeesExecutions = new HashSet<SprEmployeesExecution>();
            SprEmployeesJobPosCombinations = new HashSet<SprEmployeesJobPosCombination>();
            SprEmployeesRoleJoins = new HashSet<SprEmployeesRoleJoin>();
            SprEmployeesSalaries = new HashSet<SprEmployeesSalary>();
            SprEmployeesStatusJoins = new HashSet<SprEmployeesStatusJoin>();
        }

        public Guid Id { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateStop { get; set; }
        public int? SprEmployeesJobPosId { get; set; }
        public decimal? EmployeesStake { get; set; }
        public string EmployeesMfcName { get; set; }
        public string EmployeesFio { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }
        public string Commentt { get; set; }

        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprEmployeesJobPo SprEmployeesJobPos { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual ICollection<SprEmployeesExecution> SprEmployeesExecutions { get; set; }
        public virtual ICollection<SprEmployeesJobPosCombination> SprEmployeesJobPosCombinations { get; set; }
        public virtual ICollection<SprEmployeesRoleJoin> SprEmployeesRoleJoins { get; set; }
        public virtual ICollection<SprEmployeesSalary> SprEmployeesSalaries { get; set; }
        public virtual ICollection<SprEmployeesStatusJoin> SprEmployeesStatusJoins { get; set; }
    }
}
