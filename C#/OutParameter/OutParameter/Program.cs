class Program
{
    static void Main(string[] args)
    {
        int number ;
        int number2 = 15;
        Console.WriteLine(Addition(out number, number2));
        Console.WriteLine(number);
        Console.ReadLine();
    }
    static int Addition(out int number,int number2)
    {
        number = 10;
        return number + number2;
    }
}