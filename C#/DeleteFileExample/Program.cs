using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteFileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Delete a File.
            Console.WriteLine("Delete File Example");
            File.Delete("C:\\Users\\hp\\Desktop\\C#\\OutputFilesExample\\firstfile.txt");

            Console.WriteLine("File Deleted");
            Console.ReadLine();


        }
    }
}
