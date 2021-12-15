using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataTestEmployee
    {
        public DataTestEmployee()
        {
            DataTestQuestionEmployees = new HashSet<DataTestQuestionEmployee>();
        }

        public Guid Id { get; set; }
        public Guid DataTestId { get; set; }
        public Guid SprEmployeesId { get; set; }

        public virtual DataTest DataTest { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
        public virtual ICollection<DataTestQuestionEmployee> DataTestQuestionEmployees { get; set; }
    }
}
