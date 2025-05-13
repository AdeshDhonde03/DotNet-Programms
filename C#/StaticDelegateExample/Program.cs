using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDelegateExample
{
    internal class Program
    {
        //delegate  void ContentDisplay(); //Singlecast delegate(Default delegate).

        delegate int Operation(int number1,int number2); //Mukticast delegate
        static void Main(string[] args)
        {
            ////static method delegate  
            //we can acess it throgh a class NAme.
            //ContentDisplay obj1 = Content.Display;
            //obj1();
            //ContentDisplay obj2 = Content.Hide;
            //obj2();
            //ContentDisplay obj3 = Content.Show;
            //obj3();
            //Console.ReadLine();

            Calculator calculator = new Calculator();
            Operation obj = calculator.Add;
            Console.WriteLine("Addition:"+obj(1, 4));
            Operation obj1 = calculator.Substraction;
            Console.WriteLine("Substraction:" + obj1(1, 4));
            Operation obj2 = calculator.Multiply;
            Console.WriteLine("Multiplication:" + obj2(1, 4));
            Operation obj3 = calculator.Division;
            Console.WriteLine("Division:" + obj3(1, 4));
            Console.ReadLine();

        }
    }
}
