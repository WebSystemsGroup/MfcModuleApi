using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataCallback
    {
        public DataCallback()
        {
            DataCallbackCalls = new HashSet<DataCallbackCall>();
        }

        public Guid Id { get; set; }
        public DateTime DateOrder { get; set; }
        public string PhoneNumber { get; set; }
        public string CustomerFio { get; set; }
        public int Status { get; set; }
        public int CountTry { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public int CallbackId { get; set; }
        public bool IsSync { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime? DateClose { get; set; }
        public Guid? SprEmployeesIdClose { get; set; }
        public bool IsHand { get; set; }

        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual ICollection<DataCallbackCall> DataCallbackCalls { get; set; }
    }
}
