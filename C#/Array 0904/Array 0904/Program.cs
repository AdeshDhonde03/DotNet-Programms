using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Enter Size of array");
        //int size =int.Parse( Console.ReadLine());
        //int[] arr = new int[size];

        //Console.WriteLine("Enter Array Element");

        //for(int i =0;i<size;i++)
        //{
        //    arr[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //for(int i =0; i <arr.Length;i++)
        //{
        //    Console.Write(arr[i]);
        //}
        //Console.ReadLine();



        //Reverwse a array
        //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

        //for(int i = arr.Length-1;i>=0;i--)
        //{
        //    Console.Write(" " + arr[i] + " ");
        //}
        //Console.ReadLine();


        //Find Max And min elemet in array
        //
        //int[] arr = { 1, 4, 7, 2, 5, 8, 9, 0, 3 };
        //int min = arr[0];
        //int max = arr[0];

        //for(int i =0;i<arr.Length;i++)
        //{
        //    if (arr[i]>max)

        //        max = arr[i];
        //    if (arr[i]<min)
        //    {
        //        min = arr[i];
        //    }

        //}

        //Console.WriteLine("maximum element in array is " + max);
        //Console.WriteLine("minimum element in array is " + min);

        //Console.ReadLine();

        //Find Second Largest Element in array

        //int[] arr = { 3, 4, 6, 1, 2,5 };
        //int first = int.MinValue;
        //int second = int.MinValue;

        //for (int i =0;i<arr.Length;i++)
        //{
        //    if (arr[i]>first)
        //    {
        //        second = first;
        //        first = arr[i];

        //    }
        //    else if (arr[i]>second && arr[i] != first)
        //    {
        //        second = arr[i];
        //    }

        //}
        //Console.WriteLine("Second Highest Element is " + second);

        //Console.ReadLine();

        //Sort array in descending  and ascending order

        //Console.WriteLine("Enter Size of array");
        //int size = int.Parse(Console.ReadLine());

        //int[] arr = new int[size];

        //for(int i = 0;i<arr.Length;i++)
        //{
        //    arr[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //Console.WriteLine("Array in normal order");
        //for(int i =0;i<arr.Length;i++)
        //{
        //    Console.Write(" "+arr[i]+" ");
        //}

        //Console.WriteLine();

        //Console.WriteLine("sort array in Ascending order");
        //for (int i =0;i<arr.Length;i++)
        //{
        //    for(int j = i+1;j<arr.Length;j++)
        //    {
        //        if (arr[i] > arr[j])
        //        {
        //            int temp = arr[i];
        //            arr[i] = arr[j];
        //            arr[j] = temp;
        //        }
        //    }
        //}
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.Write(" " + arr[i] + " ");
        //}


        //Console.WriteLine("sort array in Descending order");
        //for(int a = 0;a<arr.Length;a++)
        //{
        //    for(int b = a+1;b<arr.Length;b++)
        //    {
        //        if (arr[a] < arr[b])
        //        {
        //            int temp = arr[a];
        //            arr[a] = arr[b];
        //            arr[b] = temp;
        //        }
        //    }
        //}
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.Write(" " + arr[i] + " ");
        //}


        //Console.ReadLine();


        // Find Duplicate element in array

        //int[] arr = { 4, 5, 6, 2, 5, 2 };

        //for (int i =0;i<arr.Length;i++)
        //{

        //    for(int j = i+1;j<arr.Length;j++)
        //    {
        //        if (arr[i] == arr[j])
        //        {
        //            Console.WriteLine("Duplicate element in array is " + arr[i]);

        //            break;
        //        }
        //    }
        //}


        //Summ of elemrnts in array
        //
        Console.WriteLine("Enter Size of array");
        int size =Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];

        for(int i =0;i<size;i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int sum = 0;
        for(int i =0;i<arr.Length;i++)
        {
            sum = sum + arr[i];
        }
        Console.WriteLine("Sum Of are" + sum);
        Console.ReadLine();

    }
}