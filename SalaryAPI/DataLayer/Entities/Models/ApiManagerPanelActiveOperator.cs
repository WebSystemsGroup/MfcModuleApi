using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class ApiManagerPanelActiveOperator
    {
        public Guid Id { get; set; }
        public DateTime DateQuery { get; set; }
        public int CountActiveOperator { get; set; }
        public string Commentt { get; set; }
    }
}
