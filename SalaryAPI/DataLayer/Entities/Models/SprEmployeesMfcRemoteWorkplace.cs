using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprEmployeesMfcRemoteWorkplace
    {
        public SprEmployeesMfcRemoteWorkplace()
        {
            ArchiveServices = new HashSet<ArchiveService>();
            DataServices = new HashSet<DataService>();
            SprEmployees = new HashSet<SprEmployee>();
        }

        public string RemoteWorkplaceName { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public string Commentt { get; set; }
        public Guid Id { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public string EmployeesMfcName { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }
        public Guid? MdmUuid { get; set; }
        public string FrguCode { get; set; }
        public string MrsCode { get; set; }
        public string Oktmo { get; set; }

        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual ICollection<ArchiveService> ArchiveServices { get; set; }
        public virtual ICollection<DataService> DataServices { get; set; }
        public virtual ICollection<SprEmployee> SprEmployees { get; set; }
    }
}
