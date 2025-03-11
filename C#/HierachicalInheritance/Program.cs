using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierachicalInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoWheeler twoWheeler = new TwoWheeler();
            FourWheeler fourWheeler = new FourWheeler();
            Vehicle vehicle = new FourWheeler();
            Console.ReadLine();
        }
    }
}
