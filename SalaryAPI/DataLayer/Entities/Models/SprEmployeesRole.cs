using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprEmployeesRole
    {
        public SprEmployeesRole()
        {
            SprEmployeesRoleJoins = new HashSet<SprEmployeesRoleJoin>();
        }

        public string RoleName { get; set; }
        public string Commentt { get; set; }
        public int Id { get; set; }

        public virtual ICollection<SprEmployeesRoleJoin> SprEmployeesRoleJoins { get; set; }
    }
}
