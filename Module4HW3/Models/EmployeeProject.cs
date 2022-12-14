using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4HW3.Models
{
    internal class EmployeeProject
    {
        public int EmployeeProjectId { get; set; }
        public decimal? Rate { get; set; }
        public DateTime StartedTime { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
