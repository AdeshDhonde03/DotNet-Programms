class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Enter Size of Array");
        //int size = Int32.Parse(Console.ReadLine());

        //int[] arr = new int[size];
        //Console.WriteLine("Enter Array Element");
        //for (int i = 0; i < size; i++)
        //{
        //    arr[i] = Int32.Parse(Console.ReadLine());       
        //}

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.Write(arr[i]);

        //}
        //Console.ReadLine();

        //int[] arr = { 2, 3, 445, 7, 8, 9, 1, 23, 3 };
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i] % 2 != 0)
        //    {
        //        Console.Write(" "+arr[i]+" ");
        //    }
        //}
        //Console.ReadLine();

        //int[] arr = { 2, 4, 5, 1, 6, 7, 8, 3, 1, 0 };

        //for(int i = arr.Length-1;i>=0;i--)
        //{
        //    Console.Write(" " + arr[i] + " ");
        //}
        //Console.ReadLine();

        int[] arr = { 5, 3, 2, 1, 5, 78, 43, 1, 6 };
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                }
            }
        }
        Console.WriteLine("In Ascending Order");
        foreach (int num in arr)
        {
            Console.Write(" " + num + " ");
        }

        

        Console.ReadLine();
    }
}