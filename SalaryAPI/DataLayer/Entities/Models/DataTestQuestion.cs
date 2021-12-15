using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataTestQuestion
    {
        public Guid Id { get; set; }
        public Guid DataTestId { get; set; }
        public Guid SprTestQuestionId { get; set; }

        public virtual DataTest DataTest { get; set; }
        public virtual SprTestQuestion SprTestQuestion { get; set; }
    }
}
