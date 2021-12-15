using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprFeedbackQuestionType
    {
        public SprFeedbackQuestionType()
        {
            DataFeedbackQuestions = new HashSet<DataFeedbackQuestion>();
        }

        public short Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<DataFeedbackQuestion> DataFeedbackQuestions { get; set; }
    }
}
