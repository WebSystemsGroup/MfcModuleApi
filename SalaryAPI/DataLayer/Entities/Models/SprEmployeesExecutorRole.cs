using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprEmployeesExecutorRole
    {
        public Guid Id { get; set; }
        public Guid SprEmployeesId { get; set; }
        public DateTime DateAdd { get; set; }
        public string EmployeesNameAdd { get; set; }
        public Guid SprExecutorRoleId { get; set; }

        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprExecutorRole SprExecutorRole { get; set; }
    }
}
