using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprEmployeesStatus
    {
        public SprEmployeesStatus()
        {
            SprEmployeesStatusJoins = new HashSet<SprEmployeesStatusJoin>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; }
        public string Commentt { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public int? SortId { get; set; }

        public virtual ICollection<SprEmployeesStatusJoin> SprEmployeesStatusJoins { get; set; }
    }
}
