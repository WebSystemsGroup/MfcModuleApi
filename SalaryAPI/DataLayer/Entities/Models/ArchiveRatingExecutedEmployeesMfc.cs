using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ArchiveRatingExecutedEmployeesMfc
    {
        public Guid Id { get; set; }
        public Guid SprEmployeesMfcId { get; set; }
        public DateTime PeriodDate { get; set; }
        public int PeriodMonth { get; set; }
        public int PeriodYear { get; set; }
        public int DayRating { get; set; }
        public int DayPosition { get; set; }
        public int MonthRating { get; set; }
        public int MonthPosition { get; set; }
        public int AllRating { get; set; }
        public int AllPosition { get; set; }
        public string EmployeesMfcName { get; set; }
        public int YearRating { get; set; }
        public int YearPosition { get; set; }
        public int DayPositionMoving { get; set; }
        public int MonthPositionMoving { get; set; }
        public int YearPositionMoving { get; set; }
        public int AllPositionMoving { get; set; }

        public virtual SprEmployeesMfc SprEmployeesMfc { get; set; }
    }
}
