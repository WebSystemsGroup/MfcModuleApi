using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataIasMkguRatingLoad
    {
        public Guid Id { get; set; }
        public string FrguProviderId { get; set; }
        public string FrguServicesId { get; set; }
        public short SprIasMkguIndicatorId { get; set; }
        public short SprIasMkguCategoryId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public short? RatingValue { get; set; }
        public short? PositivePercent { get; set; }
        public DateTime SetDate { get; set; }

        public virtual SprIasMkguCategory SprIasMkguCategory { get; set; }
        public virtual SprIasMkguIndicator SprIasMkguIndicator { get; set; }
    }
}
