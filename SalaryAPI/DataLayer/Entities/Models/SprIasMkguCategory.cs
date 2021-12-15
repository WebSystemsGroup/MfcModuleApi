using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprIasMkguCategory
    {
        public SprIasMkguCategory()
        {
            DataIasMkguRatingLoads = new HashSet<DataIasMkguRatingLoad>();
        }

        public short Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<DataIasMkguRatingLoad> DataIasMkguRatingLoads { get; set; }
    }
}
