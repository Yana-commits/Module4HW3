using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4HW3.Models
{
    internal class Title
    {
        public int TitleId { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
