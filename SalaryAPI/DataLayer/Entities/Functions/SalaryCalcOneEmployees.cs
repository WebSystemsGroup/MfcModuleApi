using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities.Functions
{
    public class SalaryCalcOneEmployees
    {
        [Column("out_employees_salary")]
        public float Salary { get; set; }
        [Column("out_employees_stake")]
        public float Stake { get; set; }
        [Column("out_employees_premium")]
        public float Premium { get; set; }
        [Column("out_fine_percent")]
        public float Percent { get; set; }
        [Column("out_fine_sum")]
        public float FineSum { get; set; }
        [Column("out_employees_premium_total")]
        public float PremiumTotal { get; set; }
        [Column("out_step_premium")]
        public float StepPremium { get; set; }
        [Column("out_step_premium_other")]
        public float PremiumOther { get; set; }
    }
}
