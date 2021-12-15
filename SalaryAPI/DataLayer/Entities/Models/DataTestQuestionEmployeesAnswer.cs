using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataTestQuestionEmployeesAnswer
    {
        public Guid Id { get; set; }
        public Guid DataTestQuestionEmployeesId { get; set; }
        public Guid SprTestAnswerId { get; set; }
        public string Answer { get; set; }
        public bool? IsTrue { get; set; }
        public DateTime DateAnswer { get; set; }

        public virtual DataTestQuestionEmployee DataTestQuestionEmployees { get; set; }
        public virtual SprTestAnswer SprTestAnswer { get; set; }
    }
}
