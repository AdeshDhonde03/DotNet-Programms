class Program
{
    static void Main(string[] args)
    {
        int number = 5;
        int number2 = 12;
        Console.WriteLine(Addition(ref number, number2));
        Console.WriteLine(number);
        Console.ReadLine();
    }
    static int Addition(ref int number,int number2)
    {
        number = 25;
        return number + number2;
    }
}