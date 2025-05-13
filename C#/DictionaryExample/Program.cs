using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary Example");
            SortedList<int,string> roomtype= new SortedList<int, string>();
            roomtype.Add(1, "1BHK");
            roomtype.Add(3, "3BHK");
            roomtype.Add(2, "2BHK");
           
            Console.WriteLine("Reading Element from dictionary");


            if(roomtype.Count>0)
            {
                foreach (var room in roomtype)
                {
                    Console.WriteLine("Room Id:" + room.Key + "Room Name:" + room.Value);
                }
               
            }
            Console.ReadLine();


        }
    }
}
