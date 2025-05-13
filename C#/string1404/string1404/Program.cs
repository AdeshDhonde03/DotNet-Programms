static class Program
{
    static void Main(string[] args)
    {
        //Reverse a String 
        //Console.WriteLine("Enter Any String");
        //string str = Console.ReadLine();
        //string reversed = "";

        //for(int i = str.Length-1;i>=0;i--)
        //{
        //    reversed = reversed + str[i];
        //}
        //Console.WriteLine("Reversed String===" + reversed);
        //Console.ReadLine();

        //count vowels and constants

        Console.WriteLine("Enter Any String");
        string str = Console.ReadLine();
        str = str.ToLower();
        //int constant = 0, vowels = 0;
        string result = "";

        for(int i = 0;i<str.Length-1;i++)
        {
            char ch = str[i];
            if(ch>='a' && ch<='z')
            {
                if(ch=='a' || ch=='e' || ch=='i'|| ch=='o' || ch =='u')
                {
                   
                }
                
            }
        }
        

        Console.ReadLine();

    }
}