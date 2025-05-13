using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisherobj=new Publisher();
            Subscriber subcriberobj = new Subscriber();

            MyEventHandler delobj = publisherobj.RaseEvent;
            delobj += subcriberobj.ReceiveMessage;
            //delobj -= subcriberobj.ReceiveMessage;
            delobj("Event Example trigger");
            Console.ReadLine();
        }
    }
}
