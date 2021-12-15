using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataTestQuestionEmployee
    {
        public DataTestQuestionEmployee()
        {
            DataTestQuestionEmployeesAnswers = new HashSet<DataTestQuestionEmployeesAnswer>();
        }

        public Guid Id { get; set; }
        public int TestNumber { get; set; }
        public string TestName { get; set; }
        public string EmployeeFio { get; set; }
        public Guid SprTestDirectionId { get; set; }
        public string DirectionName { get; set; }
        public Guid SprTestQuestionId { get; set; }
        public string Question { get; set; }
        public bool Type { get; set; }
        public bool? IsTrueAnswer { get; set; }
        public int SprEmployeesJobPosId { get; set; }
        public string JobPosName { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public string MfcName { get; set; }
        public DateTime DateQuestion { get; set; }
        public Guid DataTestEmployeesId { get; set; }

        public virtual DataTestEmployee DataTestEmployees { get; set; }
        public virtual SprEmployeesJobPo SprEmployeesJobPos { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual SprTestDirection SprTestDirection { get; set; }
        public virtual SprTestQuestion SprTestQuestion { get; set; }
        public virtual ICollection<DataTestQuestionEmployeesAnswer> DataTestQuestionEmployeesAnswers { get; set; }
    }
}
