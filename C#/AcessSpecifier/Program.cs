using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessSpecifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee = new Employee();
            string value = employee.Acesss();
            

            RoomServices roomServices = new RoomServices();
            roomServices.GetRoomType();
            Console.ReadLine();
            
        }
    }
}
