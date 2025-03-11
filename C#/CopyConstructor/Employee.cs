using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Helo Copy");
        }
        public Employee(Employee employee)
        {
            Console.WriteLine("Hello copy constructor");
            

        }
        public void GetMessage()
        {
            Console.WriteLine("Good Morning");
        }
        public void GetName()
        {
            Console.WriteLine("Adesh");
        }
    }
}
