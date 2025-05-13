using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericQueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Non generic queue example");
            Queue queue = new Queue();
            queue.Enqueue(1);
             queue.Enqueue(2);
            queue.Enqueue("Adesh");

            if (queue.Count > 0)
            {
                foreach (var item in queue)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }
        }
    }
}
