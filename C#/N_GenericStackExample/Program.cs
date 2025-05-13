using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_GenericStackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Non Generic Stack Example");
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("Adesh");

            Console.WriteLine("Reading element");
            if (stack.Count > 0)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }
        }
    }
}
