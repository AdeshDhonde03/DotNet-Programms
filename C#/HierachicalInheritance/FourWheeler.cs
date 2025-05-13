using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierachicalInheritance
{
    public class FourWheeler : Vehicle
    {
        public FourWheeler() 
        {
            Console.WriteLine("Fourwheeler");
        }
        public int ChesiNo { get; set; }
    }
}
