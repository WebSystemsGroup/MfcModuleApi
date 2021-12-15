using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities.Functions
{
    public class ApiExpiredStage
    {
        [Column("out_count_currrent")]
        public int CountCurrent { get; set; }
        [Column("out_count_expired")]
        public int CountExpired { get; set; }
        [Column("out_percent")]
        public decimal Percent { get; set; }
    }
}
