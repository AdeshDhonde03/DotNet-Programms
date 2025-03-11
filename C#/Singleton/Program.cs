using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee.GetMessage();
            Employee.GetEmployee();
            Console.ReadLine();
        }
    }
}
