using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprTestQuestionJobPo
    {
        public Guid Id { get; set; }
        public int SprEmployeesJobPosId { get; set; }
        public Guid SprTestQuestionId { get; set; }

        public virtual SprEmployeesJobPo SprEmployeesJobPos { get; set; }
        public virtual SprTestQuestion SprTestQuestion { get; set; }
    }
}
