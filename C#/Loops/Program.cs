using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // print a number
            for (int number = 1; number <= 10; number++)
            {

                Console.WriteLine(number);

            }
            Console.ReadLine();

            //Escape any Number in Loop
            for (int number = 1; number <= 10; number++)
            {
                if (number == 5)
                {
                    continue;
                }

                Console.WriteLine(number);

            }
            Console.ReadLine();

            //Loop in till any Number
            for (int number = 1; number <= 10; number++)
            {
                if (number == 4)
                {
                    break;
                }

                Console.WriteLine(number);

            }
            Console.ReadLine();

            //Pattern Printing 1
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //Pattern printing 2

           // for (int i = 1; i <= 5; i++)
           // {
           //     for (int j = 1; j <= i; j++)
           //     {
           //         Console.Write("*");
           //     }
           //     Console.WriteLine();
           // }
           // Console.ReadLine();

           // //Pattern Printing In  Numbers
           // for (int i = 1; i <= 5; i++)
           // {
           //     for (int j = 1; j <= i; j++)
           //     {
           //         Console.Write(j);
           //     }
           //     Console.WriteLine();
           // }
           // Console.ReadLine();


           // //While Loop
           // int i = 0;
           // while (i < 5)
           // {
           //     Console.WriteLine(i);
           //     i++;
           // }
           // Console.ReadLine();


           //// Do while loop
           // int i = 0;
           // do
           // {
           //     Console.WriteLine(i);
           //     i++;


           // } while (i < 5);
           // Console.ReadLine();


           // for (int number; number >= 0; number--)
           // {
           //     Console.WriteLine(number);
           // }
           // Console.ReadLine();
        }
    }

}