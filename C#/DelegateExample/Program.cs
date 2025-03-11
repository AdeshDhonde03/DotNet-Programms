using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    internal class Program
    {
        delegate void ContentDisplay(); // Delegate syntax

        static void Main(string[] args)
        {
            Content obj= new Content();
            ContentDisplay obj0 = obj.Show;
            obj0();
            ContentDisplay obj1 = obj.Display;
            obj1();
            ContentDisplay obj2 = obj.Hide;
            obj2();
            Console.ReadLine();
        }
    }
}
