using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Example:");

            Queue<int>queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            foreach (int item in queue)
            {
                Console.WriteLine("queue Element:" + item);
            }
            Console.ReadLine();
        }
    }
}
