using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchiveServicesParametr
    {
        public Guid Id { get; set; }
        public string ArchiveServicesInfoId { get; set; }
        public Guid ArchiveServicesId { get; set; }
        public int SprParametrId { get; set; }
        public string ParametrName { get; set; }
        public string ParametrType { get; set; }
        public string ParametrValue { get; set; }
        public short? RowDel { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public string Mnemo { get; set; }

        public virtual ArchiveService ArchiveServices { get; set; }
        public virtual ArchiveServicesInfo ArchiveServicesInfo { get; set; }
        public virtual SprParametr SprParametr { get; set; }
    }
}
