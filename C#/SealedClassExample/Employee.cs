using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    public class Employee :AccountInformation
    {
        public Employee() 
        {
            Console.WriteLine("Employee Class");
        }
        public string Name { get; set; }
    }
}
