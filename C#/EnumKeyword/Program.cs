using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enum Example");
            CrossinRequest request = new CrossinRequest();
            request.pricelevel = PriceLevelConstant.ListedpriceLevel;
            if (PriceLevel.Listed.ToString().ToLower()==request.pricelevel.ToLower())
            {
                Console.WriteLine("This medicine process for te sell");
            }
            Console.ReadLine();

        
        }
    }
}
