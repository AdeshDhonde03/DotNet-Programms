using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample2
{
    public delegate void MyEventHandler();
    public  class Print
    {
        public event MyEventHandler MessageSender;

        public void Printdata()
        {
            MessageSender?.Invoke();
        }

    }
}
