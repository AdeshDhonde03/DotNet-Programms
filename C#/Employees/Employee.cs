using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employee : AuditEntity
    {
       
        public string Emp_Name { get; set; }
        public string EmpEmail{ get; set; }
        public string MobileNo { get; set; }


    }
}
