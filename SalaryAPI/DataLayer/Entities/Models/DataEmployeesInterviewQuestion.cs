using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataEmployeesInterviewQuestion
    {
        public DataEmployeesInterviewQuestion()
        {
            DataEmployeesInterviewAnswers = new HashSet<DataEmployeesInterviewAnswer>();
        }

        public Guid Id { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateStop { get; set; }
        public string Questions { get; set; }

        public virtual ICollection<DataEmployeesInterviewAnswer> DataEmployeesInterviewAnswers { get; set; }
    }
}
