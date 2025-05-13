using Singleton;

class Program()
{
    static void Main(string[] args)
    {
        Singldto1 obj1 = Singldto1.GetInstance();
        Singldto1 obj2 = Singldto1.GetInstance();

    }
}