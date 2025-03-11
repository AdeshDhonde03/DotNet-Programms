using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    internal class Status
    {
        public string GetStatus()
        {
            return "APPROVED";
        }
        public string StatusValue(string status)
        {
            return status ;
        }
        public string RequestType()
        {
            return "Web";
        }

    }
}
