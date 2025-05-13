using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierachicalInheritance
{
    public class Vehicle
    {
        public Vehicle()
        {
            Console.WriteLine("Vehicle class");
        }
        public string Name { get; set; }    
        public string Type{ get; set; }
    }
}
