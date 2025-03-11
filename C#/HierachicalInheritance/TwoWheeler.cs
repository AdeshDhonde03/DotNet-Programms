using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierachicalInheritance
{
    public class TwoWheeler : Vehicle
    {
        public TwoWheeler() 
        {
            Console.WriteLine("Twowheeler");
        }
        public int ModelNo { get; set; }
    }
}
