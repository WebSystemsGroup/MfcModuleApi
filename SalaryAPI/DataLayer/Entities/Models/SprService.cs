using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprService
    {
        public SprService()
        {
            SprServicesSubs = new HashSet<SprServicesSub>();
        }

        public Guid Id { get; set; }
        public Guid SprServicesProviderDepartmentId { get; set; }
        public string ServiceMnemo { get; set; }
        public string ServiceName { get; set; }
        public string ServiceNameSmall { get; set; }
        public string Commentt { get; set; }
        public string ServiceRegulations { get; set; }
        public string FrguServicesId { get; set; }
        public Guid SprServicesTypeId { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public string FrguServicesName { get; set; }
        public short? RowDel { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public string FrguProcedureId { get; set; }
        public Guid? MdmUuid { get; set; }

        public virtual SprServicesProviderDepartment SprServicesProviderDepartment { get; set; }
        public virtual SprServicesType SprServicesType { get; set; }
        public virtual ICollection<SprServicesSub> SprServicesSubs { get; set; }
    }
}
