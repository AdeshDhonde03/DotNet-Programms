using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Option:");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    {     
                        Console.WriteLine("monday");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Tuesday");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Wednsday");
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Thursday");
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Friaday");
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("Saturday");
                    }
                    break;
                default:
                    {

                        Console.WriteLine("Enter valid option");
                    }
                    break;
                    

            }
            Console.ReadLine();

        }
    }
}
