using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataEmployeesAlert
    {
        public Guid Id { get; set; }
        public string DataServicesInfoId { get; set; }
        public Guid? DataServicesCommenttId { get; set; }
        public string CustomerName { get; set; }
        public string ServiceName { get; set; }
        public string RequestName { get; set; }
        public string Commentt { get; set; }
        public DateTime SetDate { get; set; }
        public string CustomerTel1 { get; set; }
        public string CustomerTel2 { get; set; }
        public string CustomerEmail { get; set; }
        public Guid? DataServicesId { get; set; }
        public short AlertType { get; set; }
        public Guid SprEmployeesId { get; set; }
        public string DataFeedbackQuestionTicketId { get; set; }
        public Guid? DataTestId { get; set; }
        public Guid? DataServicesSmevRequestId { get; set; }

        public virtual DataServicesInfo DataServicesInfo { get; set; }
        public virtual DataServicesSmevRequest DataServicesSmevRequest { get; set; }
        public virtual DataTest DataTest { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
    }
}
