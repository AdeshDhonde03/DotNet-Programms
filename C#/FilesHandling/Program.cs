using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace FilesHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //File create and write
            Console.WriteLine("Files Ctrate Example");
            string filepath = "C:\\Users\\hp\\Desktop\\C#\\OutputFilesExample\\FirstFile.txt";
            //File.Create(filepath);
            if (File.Exists(filepath))
            {
                
                string content = File.ReadAllText(filepath);
                Console.WriteLine("File created and write and Read");
                Console.WriteLine(content);

                //Copy the file
                String sourceFile = "C:\\Users\\hp\\Desktop\\C#\\OutputFilesExample\\FirstFile.txt";
                string destinationfile = "C:\\Users\\hp\\Desktop\\C#\\OutputFilesExample\\FirstFile1.txt";
                File.Copy(sourceFile, destinationfile, true );


               
            }
            //Date and Time
            DateTime dt = File.GetCreationTime(filepath);
            Console.WriteLine(dt);
            Console.ReadLine();
        }
    }
}
