using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataServicesTempStatistic
    {
        public Guid Id { get; set; }
        public Guid SprEmployeesId { get; set; }
        public DateTime SetDate { get; set; }
    }
}
