using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singldto1
    {
        private static Singldto1 _instance;
        private Singldto1() {
            Console.WriteLine("Object is Created");
        }

        public static Singldto1 GetInstance()
        {
            if(_instance==null)
            {
                _instance = new Singldto1();
                
            }
            return _instance;
        }


    }
}
