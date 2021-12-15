using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprListsValue
    {
        public Guid Id { get; set; }
        public int SprListsId { get; set; }
        public int Key { get; set; }
        public string Value { get; set; }

        public virtual SprList SprLists { get; set; }
    }
}
