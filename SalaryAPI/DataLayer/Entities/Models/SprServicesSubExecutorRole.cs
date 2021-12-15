using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesSubExecutorRole
    {
        public Guid Id { get; set; }
        public Guid SprServicesSubId { get; set; }
        public Guid SprExecutorRoleId { get; set; }
        public DateTime DateAdd { get; set; }
        public string EmployeesNameAdd { get; set; }
        public Guid? SprEmployeesMfcId { get; set; }

        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual SprExecutorRole SprExecutorRole { get; set; }
        public virtual SprServicesSub SprServicesSub { get; set; }
    }
}
