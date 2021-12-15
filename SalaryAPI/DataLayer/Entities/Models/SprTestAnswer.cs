using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprTestAnswer
    {
        public SprTestAnswer()
        {
            DataTestQuestionEmployeesAnswers = new HashSet<DataTestQuestionEmployeesAnswer>();
        }

        public Guid Id { get; set; }
        public Guid SprTestQuestionId { get; set; }
        public string Answer { get; set; }
        public bool IsTrue { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public bool? IsRemove { get; set; }

        public virtual SprTestQuestion SprTestQuestion { get; set; }
        public virtual ICollection<DataTestQuestionEmployeesAnswer> DataTestQuestionEmployeesAnswers { get; set; }
    }
}
