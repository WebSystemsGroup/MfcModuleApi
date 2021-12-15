using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataEpguSubsRegCategoryJoin
    {
        public Guid Id { get; set; }
        public string Region { get; set; }
        public string DataEpguSubsRegOptionsServiceId { get; set; }
        public Guid DataEpguSubsRegCategoryCopyrightId { get; set; }
    }
}
