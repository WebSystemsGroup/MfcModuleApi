using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprEmployeesMfcType
    {
        public SprEmployeesMfcType()
        {
            SprEmployeesMfcs = new HashSet<SprEmployeesMfc>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<SprEmployeesMfc> SprEmployeesMfcs { get; set; }
    }
}
