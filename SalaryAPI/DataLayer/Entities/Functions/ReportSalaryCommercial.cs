using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities.Functions
{
    public class ReportSalaryCommercial
    {
        [Column("out_employees_fio")]
        public string EmployeeFio { get; set; }
        [Column("out_employees_job_pos_name")]
        public string JobPositionName { get; set; }
        [Column("out_premium")]
        public float Sum { get; set; }
    }
}
