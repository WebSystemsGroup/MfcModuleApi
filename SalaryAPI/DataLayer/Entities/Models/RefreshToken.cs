using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class RefreshToken
    {
        public Guid Id { get; set; }
        public Guid SprEmployeesId { get; set; }
        public string RefreshToken1 { get; set; }
        public DateTime ExpireTime { get; set; }
        public bool Used { get; set; }

        public virtual SprEmployee SprEmployees { get; set; }
    }
}
