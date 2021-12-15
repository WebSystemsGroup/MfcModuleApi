using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprIasMkguIndicator
    {
        public SprIasMkguIndicator()
        {
            DataIasMkguRatingLoads = new HashSet<DataIasMkguRatingLoad>();
        }

        public short Id { get; set; }
        public string IndicatorName { get; set; }

        public virtual ICollection<DataIasMkguRatingLoad> DataIasMkguRatingLoads { get; set; }
    }
}
