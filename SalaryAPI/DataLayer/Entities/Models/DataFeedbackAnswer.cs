using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataFeedbackAnswer
    {
        public Guid Id { get; set; }
        public Guid DataFeedbackQuestionId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public string AnswerText { get; set; }
        public DateTime SetDate { get; set; }
        public DateTime? DateRead { get; set; }

        public virtual DataFeedbackQuestion DataFeedbackQuestion { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
    }
}
