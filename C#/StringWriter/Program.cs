using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Streamwriter and streamreader Example");
            string filepath = "D:\\KYC\\tets.txt";
            using StreamWriter sw = new StreamWriter(filepath) ;
            sw.WriteLine("Adesh");
            StreamReader sr = new StreamReader(filepath);
            
            
        }
    }
}
