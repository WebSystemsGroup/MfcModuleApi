using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprTestDirection
    {
        public SprTestDirection()
        {
            DataTestDirections = new HashSet<DataTestDirection>();
            DataTestQuestionEmployees = new HashSet<DataTestQuestionEmployee>();
            SprTestQuestions = new HashSet<SprTestQuestion>();
        }

        public Guid Id { get; set; }
        public string DirectionName { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public bool? IsRemove { get; set; }

        public virtual ICollection<DataTestDirection> DataTestDirections { get; set; }
        public virtual ICollection<DataTestQuestionEmployee> DataTestQuestionEmployees { get; set; }
        public virtual ICollection<SprTestQuestion> SprTestQuestions { get; set; }
    }
}
