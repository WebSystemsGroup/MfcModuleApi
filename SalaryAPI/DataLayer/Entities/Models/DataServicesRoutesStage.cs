using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataServicesRoutesStage
    {
        public Guid Id { get; set; }
        public Guid DataServicesId { get; set; }
        public Guid DataServicesIdParent { get; set; }
        public int SprRoutesStageId { get; set; }
        public string DataServicesInfoId { get; set; }
        public short SprServicesSubWeekId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public string EmployeesFio { get; set; }
        public DateTime DateStart { get; set; }
        public TimeSpan TimeStart { get; set; }
        public short CountDayExecution { get; set; }
        public short? CountDayFact { get; set; }
        public DateTime? DateFinishReg { get; set; }
        public DateTime? DateFinishFact { get; set; }
        public TimeSpan? TimeFinishFact { get; set; }
        public string Commentt { get; set; }
        public DateTime? DateRead { get; set; }
        public string EmployeesFioRead { get; set; }
        public DateTime? SetDate { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public int SprEmployeesJobPosId { get; set; }
        public bool PassAutomatically { get; set; }
        public string EmployeesMfcName { get; set; }
        public string EmployeesJobPosName { get; set; }
        public string EmployeesFioFact { get; set; }
        public string EmployeesFioModify { get; set; }
        public DateTime? DateAdd { get; set; }
        public string EmployeesFioAdd { get; set; }

        public virtual DataService DataServices { get; set; }
        public virtual DataServicesInfo DataServicesInfo { get; set; }
        public virtual SprEmployee SprEmployees { get; set; }
        public virtual SprEmployeesJobPo SprEmployeesJobPos { get; set; }
        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
        public virtual SprRoutesStage SprRoutesStage { get; set; }
        public virtual SprServicesSubWeek SprServicesSubWeek { get; set; }
    }
}
