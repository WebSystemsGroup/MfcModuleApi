using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprTestQuestion
    {
        public SprTestQuestion()
        {
            DataTestQuestionEmployees = new HashSet<DataTestQuestionEmployee>();
            DataTestQuestions = new HashSet<DataTestQuestion>();
            SprTestAnswers = new HashSet<SprTestAnswer>();
            SprTestQuestionJobPos = new HashSet<SprTestQuestionJobPo>();
        }

        public Guid Id { get; set; }
        public string Question { get; set; }
        public bool Type { get; set; }
        public bool? Actuality { get; set; }
        public Guid SprTestDirectionId { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public bool? IsRemove { get; set; }

        public virtual SprTestDirection SprTestDirection { get; set; }
        public virtual ICollection<DataTestQuestionEmployee> DataTestQuestionEmployees { get; set; }
        public virtual ICollection<DataTestQuestion> DataTestQuestions { get; set; }
        public virtual ICollection<SprTestAnswer> SprTestAnswers { get; set; }
        public virtual ICollection<SprTestQuestionJobPo> SprTestQuestionJobPos { get; set; }
    }
}
