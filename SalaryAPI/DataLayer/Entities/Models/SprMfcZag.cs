using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprMfcZag
    {
        public Guid SprEmployeesMfcId { get; set; }
        public string ZagsCode { get; set; }
        public string ZagsName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int RowDel { get; set; }
        public int Id { get; set; }

        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
    }
}
