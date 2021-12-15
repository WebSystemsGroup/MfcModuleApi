using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprServicesProviderDepartment
    {
        public SprServicesProviderDepartment()
        {
            SprServices = new HashSet<SprService>();
        }

        public Guid Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentAddress { get; set; }
        public string DepartmentDirector { get; set; }
        public string DepartmentTel { get; set; }
        public string DepartmentEmail { get; set; }
        public string Commentt { get; set; }
        public Guid SprServicesProviderId { get; set; }
        public string DepartmentNameSmall { get; set; }
        public short? RowDel { get; set; }
        public string FrguDepartmentId { get; set; }
        public string FrguDepartmentName { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public DateTime? SetDate { get; set; }
        public string SetEmployeesFio { get; set; }

        public virtual SprServicesProvider SprServicesProvider { get; set; }
        public virtual ICollection<SprService> SprServices { get; set; }
    }
}
