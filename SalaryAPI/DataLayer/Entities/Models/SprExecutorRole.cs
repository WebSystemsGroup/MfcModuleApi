using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprExecutorRole
    {
        public SprExecutorRole()
        {
            SprEmployeesExecutorRoles = new HashSet<SprEmployeesExecutorRole>();
            SprServicesSubExecutorRoles = new HashSet<SprServicesSubExecutorRole>();
        }

        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdd { get; set; }
        public string EmployeesNameAdd { get; set; }

        public virtual ICollection<SprEmployeesExecutorRole> SprEmployeesExecutorRoles { get; set; }
        public virtual ICollection<SprServicesSubExecutorRole> SprServicesSubExecutorRoles { get; set; }
    }
}
