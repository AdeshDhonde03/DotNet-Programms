using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessSpecifier
{
    public class Company
    {
        protected string GetGstNo()
        {
            return "HCAPD19";
        }
    }
    public class Employee:Company

    {
      public string Acesss()
        {
            GetGstNo();
            return "Value";
        }
    }
    //public class Manager : Company
    //{
        
    //}

}
