using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities.Functions
{
    public class ApiServicesDay
    {
        [Column("out_count_received")]
        public int CountDayReceived { get; set; }
        [Column("out_count_executed")]
        public int CountDayExecuted { get; set; }
    }
}
