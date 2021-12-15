using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprSmevRequest
    {
        public SprSmevRequest()
        {
            ArchiveServicesSmevRequests = new HashSet<ArchiveServicesSmevRequest>();
            DataReportSmevStatistics = new HashSet<DataReportSmevStatistic>();
            DataServicesIncomingSmevRequests = new HashSet<DataServicesIncomingSmevRequest>();
            DataServicesSmevRequests = new HashSet<DataServicesSmevRequest>();
            SprDocumentsSmevRequestJoins = new HashSet<SprDocumentsSmevRequestJoin>();
            SprServicesSubSmevRequestJoins = new HashSet<SprServicesSubSmevRequestJoin>();
        }

        public int Id { get; set; }
        public Guid SprSmevId { get; set; }
        public string RequestName { get; set; }
        public short SprServicesSubWeekId { get; set; }
        public short? CountDayExecution { get; set; }
        public short SprSmevTypeRequestId { get; set; }
        public bool? RequestActive { get; set; }
        public string Commentt { get; set; }
        public DateTime SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public string Path { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }
        public string ServiceOrFunctionCode { get; set; }
        public bool? IncludeInReport { get; set; }

        public virtual SprServicesSubWeek SprServicesSubWeek { get; set; }
        public virtual SprSmev SprSmev { get; set; }
        public virtual SprSmevTypeRequest SprSmevTypeRequest { get; set; }
        public virtual ICollection<ArchiveServicesSmevRequest> ArchiveServicesSmevRequests { get; set; }
        public virtual ICollection<DataReportSmevStatistic> DataReportSmevStatistics { get; set; }
        public virtual ICollection<DataServicesIncomingSmevRequest> DataServicesIncomingSmevRequests { get; set; }
        public virtual ICollection<DataServicesSmevRequest> DataServicesSmevRequests { get; set; }
        public virtual ICollection<SprDocumentsSmevRequestJoin> SprDocumentsSmevRequestJoins { get; set; }
        public virtual ICollection<SprServicesSubSmevRequestJoin> SprServicesSubSmevRequestJoins { get; set; }
    }
}
