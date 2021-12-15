using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprList
    {
        public SprList()
        {
            SprListsValues = new HashSet<SprListsValue>();
        }

        public int Id { get; set; }
        public string ListName { get; set; }

        public virtual ICollection<SprListsValue> SprListsValues { get; set; }
    }
}
