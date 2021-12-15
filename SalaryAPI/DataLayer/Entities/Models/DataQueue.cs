using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataQueue
    {
        public DataQueue()
        {
            DataQueueInfos = new HashSet<DataQueueInfo>();
        }

        public Guid Id { get; set; }
        public DateTime DateQuery { get; set; }
        public DateTime DateAnswer { get; set; }
        public string Commentt { get; set; }

        public virtual ICollection<DataQueueInfo> DataQueueInfos { get; set; }
    }
}
