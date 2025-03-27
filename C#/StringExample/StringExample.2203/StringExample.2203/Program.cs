using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        //String Pallindrome

        //string str = "madam";
        //string reversed = "";

        //for(int i = str.Length-1;i>=0;i--)
        //{
        //    reversed = reversed + str[i];
        //}

        //Console.WriteLine("Reversed String is = " + reversed);

        //if(reversed == str)
        //{
        //    Console.WriteLine("String is Pallindrome");
        //}
        //else
        //{
        //    Console.WriteLine("String is Not Pallindrome");

        //}

        //Console.ReadLine();


        //Find  Non Repeating character in string

        //string str = "aaddessh";

        //for (int i = 0;i<str.Length;i++)
        //{
        //    bool isUnique = true;
        //    for (int j=0;j<str.Length;j++)
        //    {
        //        if(i!=j && str[i] == str[j] )
        //        {
        //            isUnique = false;
        //            break;
        //        }

        //    }
        //    if(isUnique)
        //    {
        //        Console.WriteLine("Non Repeating word is = " + str[i]);
        //        break;
        //    }

        //}
        //Console.ReadLine();


        //Remove Duplicate character from string

        string str = "aadeessh";
        string result = "";

        for(int i=0;i<str.Length;i++)
        {
            bool isDuplicate = false;
            for(int j =i+1;j<str.Length;j++)
            {
                if (str[i] == str[j])
                {
                    isDuplicate = true;
                    break;
                }

            }
           if(!isDuplicate)
            {
                result = result + str[i];
            }

        }
        Console.WriteLine("New String Is" + result);
        Console.ReadLine();
    }
}