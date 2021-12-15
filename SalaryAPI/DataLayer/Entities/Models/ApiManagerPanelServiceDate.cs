using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Models
{
    public partial class ApiManagerPanelServiceDate
    {
        public ApiManagerPanelServiceDate()
        {
            ApiManagerPanelServicePeriods = new HashSet<ApiManagerPanelServicePeriod>();
        }

        public Guid Id { get; set; }
        public DateTime DateQuery { get; set; }
        public DateTime DateAnswer { get; set; }
        public string Commentt { get; set; }
        public int ReceivedCountMonth { get; set; }
        public int ExecutedCountMonth { get; set; }
        public int CountExecutionService { get; set; }
        public int CountExpiredService { get; set; }
        public int CountExpiredStages { get; set; }
        public decimal PercentExpiredService { get; set; }
        public decimal PercentExpiredStages { get; set; }

        public virtual ICollection<ApiManagerPanelServicePeriod> ApiManagerPanelServicePeriods { get; set; }
    }
}
