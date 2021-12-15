using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities.Functions
{
    public class ApiReceivedServices
    {
        [Column("out_count_week")]
        public int CountWeek { get; set; }
        [Column("out_count_month")]
        public int CountMonth { get; set; }
        [Column("out_count_quarter")]
        public int CountQuarter { get; set; }
        [Column("out_count_year")]
        public int CountYear { get; set; }
    }
}
