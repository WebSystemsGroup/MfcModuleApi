using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchiveRatingReceivedEmployee
    {
        public Guid Id { get; set; }
        public Guid? SprEmployeesMfcId { get; set; }
        public Guid SprEmployeesId { get; set; }
        public DateTime PeriodDate { get; set; }
        public int PeriodMonth { get; set; }
        public int PeriodYear { get; set; }
        public int DayRating { get; set; }
        public int DayPosition { get; set; }
        public int MonthRating { get; set; }
        public int MonthPosition { get; set; }
        public int AllRating { get; set; }
        public int AllPosition { get; set; }
        public int DayPositionMfc { get; set; }
        public int MonthPositionMfc { get; set; }
        public int AllPositionMfc { get; set; }
        public string EmployeesFio { get; set; }
        public string EmployeesMfcName { get; set; }
        public int YearRating { get; set; }
        public int? YearPosition { get; set; }
        public int YearPositionMfc { get; set; }
        public string EmployeesJobPosName { get; set; }
        public int DayPositionMoving { get; set; }
        public int MonthPositionMoving { get; set; }
        public int YearPositionMoving { get; set; }
        public int AllPositionMoving { get; set; }
        public int DayPositionMovingMfc { get; set; }
        public int MonthPositionMovingMfc { get; set; }
        public int YearPositionMovingMfc { get; set; }
        public int AllPositionMovingMfc { get; set; }

        public virtual SprEmployee SprEmployees { get; set; }
    }
}
