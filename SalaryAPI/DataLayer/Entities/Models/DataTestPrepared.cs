using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataTestPrepared
    {
        public Guid Id { get; set; }
        public Guid DataTestId { get; set; }
        public Guid? SprEmployeesId { get; set; }
        public string TrueQuestion { get; set; }
        public decimal? PercentTrue { get; set; }

        public virtual DataTest DataTest { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
    }
}
