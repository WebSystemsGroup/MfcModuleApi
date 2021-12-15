using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprEmployeesAuthorizationLog
    {
        public Guid Id { get; set; }
        public Guid SprEmployeesId { get; set; }
        public DateTime LogInDate { get; set; }
        public string LogInBrowserName { get; set; }
        public string LogInBrowserVersion { get; set; }
        public string LogInIp { get; set; }
        public string LogInProvider { get; set; }
        public string LogInIpCallCenter { get; set; }

        public virtual SprEmployee SprEmployees { get; set; }
    }
}
