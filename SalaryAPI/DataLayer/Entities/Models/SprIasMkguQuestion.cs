using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprIasMkguQuestion
    {
        public SprIasMkguQuestion()
        {
            DataIasMkguInfomatAnswers = new HashSet<DataIasMkguInfomatAnswer>();
            SprIasMkguQuestionAnswers = new HashSet<SprIasMkguQuestionAnswer>();
        }

        public int Id { get; set; }
        public string Question { get; set; }
        public string Commentt { get; set; }

        public virtual ICollection<DataIasMkguInfomatAnswer> DataIasMkguInfomatAnswers { get; set; }
        public virtual ICollection<SprIasMkguQuestionAnswer> SprIasMkguQuestionAnswers { get; set; }
    }
}
