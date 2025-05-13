using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.GetMessage();
            Employee employee2 = new Employee(employee);
            Console.ReadLine();
        }
    }
}
