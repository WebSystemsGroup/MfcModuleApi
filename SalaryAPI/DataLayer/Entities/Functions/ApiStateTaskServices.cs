using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities.Functions
{
    public class ApiStateTaskServices
    {
        [Column("out_mfc_id")]
        public Guid MfcId { get; set; }
        [Column("out_mfc_name")]
        public string MfcName { get; set; }
        [Column("out_count_plan")]
        public int? CountPlan { get; set; }
        [Column("out_count_fact")]
        public int? CountFact { get; set; }
        [Column("out_percent")]
        public decimal? Percent { get; set; }
    }
}
