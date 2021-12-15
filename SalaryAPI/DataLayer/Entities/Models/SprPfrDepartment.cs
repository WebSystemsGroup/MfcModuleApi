using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprPfrDepartment
    {
        public Guid Id { get; set; }
        public string PfrMnemo { get; set; }
        public string PfrName { get; set; }
        public DateTime? SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public int DckNumber { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }
        public string Commentt { get; set; }
        public string Okato { get; set; }
        public string Oktmo { get; set; }
    }
}
