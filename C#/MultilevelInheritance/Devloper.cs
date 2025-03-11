using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public class Devloper : Employee
    {
        public int ProjectId { get; set; }
        public string DepartmentName { get; set; }
        public  string TeamName { get; set; }
        public Devloper() 
        {
            Console.WriteLine("Developer class ");
        }
    }
}
