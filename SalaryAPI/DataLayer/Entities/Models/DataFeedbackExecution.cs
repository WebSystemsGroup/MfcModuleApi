using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataFeedbackExecution
    {
        public Guid Id { get; set; }
        public Guid DataFeedbackQuestionId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }

        public virtual DataFeedbackQuestion DataFeedbackQuestion { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
    }
}
