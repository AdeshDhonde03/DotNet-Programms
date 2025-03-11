using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    public delegate void MyEventHandler(string message);
    public class Publisher
    {
        public  event MyEventHandler MessageSenderCick;
            
    public void RaseEvent(string message)
        {
            MessageSenderCick?.Invoke(message);
        }



    }
}
