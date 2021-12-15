using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataChangeLog
    {
        public Guid Id { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime? DateChange { get; set; }
        public Guid? SprEmployeesId { get; set; }
        public string Commentt { get; set; }
        public string TableNameBase { get; set; }
        public string FieldNameBase { get; set; }
        public Guid? RowId { get; set; }
        public string EmployeesFio { get; set; }
        public string DataServicesInfoId { get; set; }
        public string IpAddress { get; set; }
    }
}
