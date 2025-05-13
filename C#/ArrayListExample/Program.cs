using System;
using System.Collections;

namespace ArrayListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayList Example");
            //without using add method
            //ArrayList countries = new ArrayList() { "IND", "US", "UK" };


            ArrayList countries = new ArrayList();
            countries.Add("India");
            countries.Add("UK");
            countries.Add("Us");
            countries.Add("America");

            Console.WriteLine("Reading ArrayList Element");
            if (countries.Count > 0)
            {
                foreach (var country in countries)
                {
                    Console.WriteLine(country);
                }
                Console.ReadLine();
            }
        }
    }
}
