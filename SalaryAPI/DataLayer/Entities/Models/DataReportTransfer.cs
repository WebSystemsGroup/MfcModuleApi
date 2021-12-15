using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataReportTransfer
    {
        public Guid Id { get; set; }
        public string DataServicesInfoId { get; set; }
        public Guid DataServicesId { get; set; }
        public string ServicesSubName { get; set; }
        public string CustomerName { get; set; }
        public string RoutesStageName { get; set; }
        public DateTime DataTransfer { get; set; }
        public Guid SprEmployeesIdOld { get; set; }
        public Guid SprEmployeesIdNew { get; set; }
        public string EmployeeFioOld { get; set; }
        public string EmployeeFioNew { get; set; }
        public Guid SprEmployeesId { get; set; }
        public Guid SprEmployeesMfcId { get; set; }

        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprEmployee SprEmployeesIdNewNavigation { get; set; }
        public virtual SprEmployee SprEmployeesIdOldNavigation { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
    }
}
