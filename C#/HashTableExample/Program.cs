using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable Countries = new Hashtable();
            Countries.Add(1,"Adesh");
            Countries.Add("IND","INDIA");

            Console.WriteLine("Reading element in hashtable");
            if(Countries.Count > 0 )
            {
                foreach( DictionaryEntry country in Countries )
                {
                    Console.WriteLine(country.Key +" "+ country.Value);
                }
                Console.ReadLine();
            }
        }
    }
}
