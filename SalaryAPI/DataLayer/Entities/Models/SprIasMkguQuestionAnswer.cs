using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprIasMkguQuestionAnswer
    {
        public SprIasMkguQuestionAnswer()
        {
            DataIasMkguInfomatAnswers = new HashSet<DataIasMkguInfomatAnswer>();
        }

        public short Id { get; set; }
        public int SprIasMkguQuestionId { get; set; }
        public string AnswerSmall { get; set; }
        public string Answer { get; set; }
        public short? AnswerRating { get; set; }

        public virtual SprIasMkguQuestion SprIasMkguQuestion { get; set; }
        public virtual ICollection<DataIasMkguInfomatAnswer> DataIasMkguInfomatAnswers { get; set; }
    }
}
