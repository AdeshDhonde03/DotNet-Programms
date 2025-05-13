using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employeeobj = new Employee();
            employeeobj.Emp_Name = "Dhonde";
            employeeobj.EmpEmail = "asdfgh3456";
            employeeobj.MobileNo = "456789";
            employeeobj.UpdatedAt = 67;
            employeeobj.UpdatedBy = 34;
            employeeobj.CreatedOn = DateTime.Now;
            employeeobj.CreatedAt = 1;
            GetEmployee();
            Console.ReadLine();
        }
        public static void GetEmployee()// set the data
        {
            Employee employee = new Employee();
            employee.Emp_Name = "Adesh";
            employee.EmpEmail = "adeshdhonde1718@gmail.com";
            employee.MobileNo = "827540";


            //Get the Data
            Console.WriteLine("Name=" + employee.Emp_Name);
            Console.WriteLine("Gmail="+employee.EmpEmail);
            Console.WriteLine("Mobile="+employee.MobileNo);
        }
    }
}
