using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysByEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week Of Days");

            Console.WriteLine("Enter A Day");
            string value = Console.ReadLine();


            Weekdays today = Weekdays.Friday;
           
            switch(today)
            {
                case Weekdays.Monday:
                    
                   Console.WriteLine("Monday");
                    break;
                case Weekdays.Tuesday:

                    Console.WriteLine("Tuesday");
                    break;
                case Weekdays.Wednesday:

                    Console.WriteLine("Wednesday");
                    break;
                case Weekdays.Thursday:

                    Console.WriteLine("Thursday");
                    break;
                case Weekdays.Friday:

                    Console.WriteLine("Friday");
                    break;
                case Weekdays.Saturday:

                    Console.WriteLine("Saturday");
                    break;
                case Weekdays.Sunday:

                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;

            }
            Console.ReadLine();
        }
    }
}
