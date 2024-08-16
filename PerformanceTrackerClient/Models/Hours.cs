using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTrackerClient.Models
{
    public class Hours
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public int StudyHours { get; set; }
        public int BreakHours { get; set; }
    }
}
