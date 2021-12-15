using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ErrorMessage
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public string InnerException { get; set; }
        public string StackTrace { get; set; }
        public string SprEmployeesFio { get; set; }
        public DateTime? Date { get; set; }
        public bool? RowDel { get; set; }
        public string ErrorCode { get; set; }
        public string TypeCode { get; set; }
    }
}
