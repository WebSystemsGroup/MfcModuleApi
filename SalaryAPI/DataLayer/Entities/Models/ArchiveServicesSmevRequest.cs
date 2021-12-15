using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchiveServicesSmevRequest
    {
        public ArchiveServicesSmevRequest()
        {
            ArchiveServicesAisOpvChats = new HashSet<ArchiveServicesAisOpvChat>();
            ArchiveServicesSmevRequestStatuses = new HashSet<ArchiveServicesSmevRequestStatus>();
        }

        public Guid Id { get; set; }
        public int SprSmevRequestId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public string MessageId { get; set; }
        public string MessageIdProvider { get; set; }
        public string RequestIdRef { get; set; }
        public DateTime? DateRequest { get; set; }
        public TimeSpan? TimeRequest { get; set; }
        public DateTime? DateResponse { get; set; }
        public TimeSpan? TimeResponse { get; set; }
        public short? CountDayExecution { get; set; }
        public short? SprServicesSubWeekId { get; set; }
        public string EmployeesFio { get; set; }
        public byte[] RequestHtml { get; set; }
        public byte[] ResponseHtml { get; set; }
        public byte[] ResponseHtmlInt { get; set; }
        public DateTime? DateRead { get; set; }
        public string EmployeesFioRead { get; set; }
        public Guid? ArchiveServicesId { get; set; }
        public DateTime? DateResponseReg { get; set; }
        public string ResponseFileName { get; set; }
        public string ArchiveServicesInfoId { get; set; }
        public string EmployeesMfcName { get; set; }
        public string EmployeesJobPosName { get; set; }
        public string Commentt { get; set; }
        public int? SprEmployeesJobPosId { get; set; }
        public Guid? SprEmployeesMfcId { get; set; }
        public bool Repeat { get; set; }

        public virtual ArchiveService ArchiveServices { get; set; }
        public virtual ArchiveServicesInfo ArchiveServicesInfo { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprSmevRequest SprSmevRequest { get; set; }
        public virtual ICollection<ArchiveServicesAisOpvChat> ArchiveServicesAisOpvChats { get; set; }
        public virtual ICollection<ArchiveServicesSmevRequestStatus> ArchiveServicesSmevRequestStatuses { get; set; }
    }
}
