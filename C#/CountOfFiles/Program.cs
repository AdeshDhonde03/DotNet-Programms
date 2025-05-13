using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Counting files in folder

            // string folderpathpath = "D:\\KYC";
            //string [] filesDetail= Directory.GetFiles(folderpathpath); //print eac file in the drive
            // Console.WriteLine("Count of Files:" + filesDetail.Count());
            // foreach (string file in filesDetail)
            // {
            //     Console.WriteLine(file);
            // }
            // Console.ReadLine();


            //count drive
            Console.WriteLine("Drive Example");
            {
                string driveName = "D:\\";
                DriveInfo[] obj= DriveInfo.GetDrives();
                Console.WriteLine("Count of All Drives:" + obj.Count()); 
                //All folders in drive.
                string [] direcoryDetails=Directory.GetDirectories(driveName);
                Console.WriteLine("All files:" + direcoryDetails);
                foreach (object items in obj)
                {
                    string[] folderdetails= Directory.GetDirectories(items.ToString());
                    foreach (object item1 in folderdetails)
                    {
                        Console.WriteLine(item1);
                    }

                }
                Console.ReadLine();
            }
        }
    }
}
