using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprEmployeesWorkingTime
    {
        public SprEmployeesWorkingTime()
        {
            SprEmployeesWorkingTimeJoins = new HashSet<SprEmployeesWorkingTimeJoin>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; }
        public string Mnemo { get; set; }
        public int? Sorting { get; set; }

        public virtual ICollection<SprEmployeesWorkingTimeJoin> SprEmployeesWorkingTimeJoins { get; set; }
    }
}
