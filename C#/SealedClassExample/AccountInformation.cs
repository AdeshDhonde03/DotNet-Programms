using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    public  class AccountInformation
    {
        public AccountInformation()
        {
            Console.WriteLine("Acoount Information class");
        
        }
        public string AccoutNumber { get; set; }
        public string Password { get; set; }
    }
}
