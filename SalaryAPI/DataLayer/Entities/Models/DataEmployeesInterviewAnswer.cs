using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataEmployeesInterviewAnswer
    {
        public Guid Id { get; set; }
        public Guid SprEmployeesId { get; set; }
        public string Answer { get; set; }
        public DateTime SetDate { get; set; }
        public Guid DataEmployeesInterviewQuestionId { get; set; }

        public virtual DataEmployeesInterviewQuestion DataEmployeesInterviewQuestion { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
    }
}
