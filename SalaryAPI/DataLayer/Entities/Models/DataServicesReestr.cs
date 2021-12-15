using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataServicesReestr
    {
        public Guid Id { get; set; }
        public string DataServicesInfoId { get; set; }
        public string CustomerFio { get; set; }
        public string ServicesProviderName { get; set; }
        public string ServicesName { get; set; }
        public int? ServicesStatus { get; set; }
        public DateTime? DateEnter { get; set; }
        public string EmployeesFio { get; set; }
        public string EmployeesFioCurrent { get; set; }
        public int? CountDay { get; set; }
        public int? CountDayStage { get; set; }
        public Guid? DataServicesId { get; set; }
        public Guid? DataReestrId { get; set; }

        public virtual DataReestr DataReestr { get; set; }
        public virtual DataService DataServices { get; set; }
    }
}
