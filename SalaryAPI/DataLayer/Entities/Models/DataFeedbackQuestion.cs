using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataFeedbackQuestion
    {
        public DataFeedbackQuestion()
        {
            DataFeedbackAnswers = new HashSet<DataFeedbackAnswer>();
            DataFeedbackExecutions = new HashSet<DataFeedbackExecution>();
        }

        public Guid Id { get; set; }
        public short SprFeedbackQuestionTypeId { get; set; }
        public string TicketId { get; set; }
        public string QuestionText { get; set; }
        public Guid SprEmployeesId { get; set; }
        public DateTime SetDate { get; set; }
        public DateTime? DateRead { get; set; }
        public string EmployeesFioRead { get; set; }
        public string Subject { get; set; }
        public bool? Closed { get; set; }
        public DateTime? DateClosed { get; set; }
        public Guid? SprEmployeesIdExecution { get; set; }

        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprFeedbackQuestionType SprFeedbackQuestionType { get; set; }
        public virtual ICollection<DataFeedbackAnswer> DataFeedbackAnswers { get; set; }
        public virtual ICollection<DataFeedbackExecution> DataFeedbackExecutions { get; set; }
    }
}
