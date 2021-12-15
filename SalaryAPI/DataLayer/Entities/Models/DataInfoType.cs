using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataInfoType
    {
        public DataInfoType()
        {
            DataInfos = new HashSet<DataInfo>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }
        public string Commentt { get; set; }

        public virtual ICollection<DataInfo> DataInfos { get; set; }
    }
}
