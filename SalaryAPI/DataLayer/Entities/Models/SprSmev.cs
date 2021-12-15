using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprSmev
    {
        public SprSmev()
        {
            SprSmevRequests = new HashSet<SprSmevRequest>();
        }

        public Guid Id { get; set; }
        public string SmevName { get; set; }
        public string SmevProvider { get; set; }
        public string ProviderUrl { get; set; }
        public string ProviderCode { get; set; }
        public string ProviderName { get; set; }
        public string SmevDescription { get; set; }
        public string Commentt { get; set; }
        public DateTime? SetDate { get; set; }
        public string SetEmployeesFio { get; set; }
        public string SmevMnemo { get; set; }
        public bool IsSmev3 { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }
        public DateTime? DateModify { get; set; }
        public string EmployeesFioModify { get; set; }
        public string CommenttModify { get; set; }
        public string IpAddressAdd { get; set; }
        public string IpAddressModify { get; set; }
        public short? RowDel { get; set; }

        public virtual ICollection<SprSmevRequest> SprSmevRequests { get; set; }
    }
}
