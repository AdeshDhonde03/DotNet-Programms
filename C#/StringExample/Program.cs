using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Status statusObj = new Status();
            //string name = "Hello Team";
            //Console.WriteLine("Length of String"+name.Length);
            //Console.WriteLine("Upeercase of string"+name.ToUpper());
            //Console.WriteLine("Lowercase of string"+name.ToLower());
           
            //string status = "Approved";
            //string requestType = "Web";
            //&&
            //if(statusObj.GetStatus().Trim().ToLower() ==status.Trim().ToLower() && statusObj.RequestType().Trim().ToLower()==requestType.Trim().ToLower())
            //{
            //    Console.WriteLine("Request Updated Sucessfully");
            //}
            //else
            //{
            //    Console.WriteLine("Request still pending");
            //}
            //Console.ReadLine();

            //||
            //if (statusObj.GetStatus().Trim().ToLower() == status.Trim().ToLower() || statusObj.RequestType().Trim().ToLower() == requestType.Trim().ToLower())
            //{
            //    Console.WriteLine("Request Updated Sucessfully");
            //}
            //else
            //{
            //    Console.WriteLine("Request still pending");
            //}
            //Console.ReadLine();

            //!
            //if (statusObj.GetStatus().Trim().ToLower() == status.Trim().ToLower()  !=(statusObj.RequestType().Trim().ToLower() == requestType.Trim().ToLower()))
            //{
            //    Console.WriteLine("Request Updated Sucessfully");
            //}
            //else
            //{
            //    Console.WriteLine("Request still pending");
            //}
            //Console.ReadLine();


            //Reverse a string

            string str;
            int count;
            Console.WriteLine("Enter any name");
            str=Console.ReadLine();
            Console.WriteLine("Reverse string is:");
            for(int i = str.Length-1;i>=0;i--)
            {

                Console.Write(str[i]);
            }
            Console.ReadLine();


            



        }
    }
}
