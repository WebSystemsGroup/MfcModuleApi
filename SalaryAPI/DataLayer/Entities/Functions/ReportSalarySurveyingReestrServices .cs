using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities.Functions
{
    public class ReportSalarySurveyingReestrServices
    {
        [Column("out_employees_fio")]
        public string EmployeeFio { get; set; }
        [Column("out_employees_job_pos_name")]
        public string JobPositionName { get; set; }
        [Column("out_service_name")]
        public string SprServicesSubName { get; set; }
        [Column("out_data_services_info_id")]
        public string DataServicesInfoId { get; set; }
        [Column("out_premium")]
        public float Sum { get; set; }
    }
}
