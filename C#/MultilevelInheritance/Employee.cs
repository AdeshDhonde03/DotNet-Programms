using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public Employee()
        {
            Console.WriteLine("Employee class");
        }
    }
}
