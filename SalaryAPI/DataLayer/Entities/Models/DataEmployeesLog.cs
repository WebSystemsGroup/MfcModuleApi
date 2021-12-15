using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataEmployeesLog
    {
        public Guid Id { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime DateModifi { get; set; }
        public string EmployeesFio { get; set; }
        public Guid SprEmployeesId { get; set; }
        public int TypeModifi { get; set; }
        public string DataServicesInfoId { get; set; }
        public string Commentt { get; set; }

        public virtual SprEmployee SprEmployees { get; set; }
    }
}
