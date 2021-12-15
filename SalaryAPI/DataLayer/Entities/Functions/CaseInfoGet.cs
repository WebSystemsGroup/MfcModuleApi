using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities.Functions
{
    public class CaseInfoGet
    {
        [Column("out_customer_name")]
        public string CustomerName { get; set; }

        [Column("out_address")]
        public string Address { get; set; }

        [Column("out_service_name")]
        public string ServicesName { get; set; }

        [Column("out_status_name")]
        public string StatusName { get; set; }

        [Column("out_date_finish_total")]
        public DateTime DateFinish { get; set; }
    }
}
