using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataTestDirection
    {
        public Guid Id { get; set; }
        public Guid DataTestId { get; set; }
        public Guid SprTestDirectionId { get; set; }

        public virtual DataTest DataTest { get; set; }
        public virtual SprTestDirection SprTestDirection { get; set; }
    }
}
