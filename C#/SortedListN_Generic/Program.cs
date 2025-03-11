using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListN_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Non Genneric sorted list example");
            SortedList countries = new SortedList();
            countries.Add(1,"IND");
            countries.Add(2, "UK");
            countries.Add(3, "US");

            Console.WriteLine("Reading Elemnets");
            if(countries.Count > 0)
            {
                foreach(DictionaryEntry country in countries)
                {
                    Console.WriteLine(country.Key +" "+ country.Value);
                }
                Console.ReadLine();
            }

        }
    }
}
