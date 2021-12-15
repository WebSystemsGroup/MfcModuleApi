using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprEmployeesRoleJoin
    {
        public Guid Id { get; set; }
        public int SprEmployeesRoleId { get; set; }
        public Guid SprEmployeesMfcJoinId { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public string Commentt { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateStop { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }

        public virtual SprEmployeesMfcJoin SprEmployeesMfcJoin { get; set; }
        public virtual SprEmployeesRole SprEmployeesRole { get; set; }
    }
}
