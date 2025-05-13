using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public static class Employee
    {
        static Employee() 
        {
            Console.WriteLine("Employee");
        }


        public static void GetMessage()
        {
            Console.WriteLine("Hello");
        }
        public static void GetEmployee()
        {
            Console.WriteLine("Name");
        }
    }
}
