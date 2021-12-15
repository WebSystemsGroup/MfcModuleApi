using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataServicesInfoFavorite
    {
        public Guid Id { get; set; }
        public string DataServicesInfoId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public DateTime SetDate { get; set; }

        public virtual DataServicesInfo DataServicesInfo { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
    }
}
