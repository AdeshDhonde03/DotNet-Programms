using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print printobj = new Print();
            Display display = new Display();

            MyEventHandler delobj = printobj.Printdata;
            delobj += display.Displaydata;
            delobj();
            Console.ReadLine();
        }
    }
}
