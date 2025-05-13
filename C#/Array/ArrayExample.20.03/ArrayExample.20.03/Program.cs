class Program
{
    static void Main(string[] args)
    {
        // Reverse a Array

        //int[] arr = { 1, 2, 3, 4, 5, 6 };

        //for(int i = arr.Length-1;i>=0;i--)
        //{
        //    Console.Write(" "+arr[i]+" ");
        //}
        //Console.ReadLine();


        // 2  Find Largest And Smallest Element in array


        //Console.WriteLine("Enter Size of Aeray:");
        //int size = int.Parse(Console.ReadLine());

        //int[] arr = { 4,3,4,5,1,9};
        //int min = arr[0];
        //int max = arr[0];


        //Console.WriteLine("Enter Array Elments");
        //for(int i =0;i<size;i++)
        //{
        //    arr[i] =Convert.ToInt32(Console.ReadLine());
        //}

        //for (int i =0;i<arr.Length;i++)
        //{
        //    if (arr[i]>max)
        //    {
        //        max = arr[i];
        //    }
        //    else if (arr[i]<min)
        //    {
        //        min = arr[i];
        //    }
        //}


        //Console.WriteLine("Your Array Elemets Are:");
        //foreach (int num in arr)
        //{
        //    Console.WriteLine(num);
        //}

        //Console.WriteLine("Largest Element is=" + max);
        //Console.WriteLine("Smallest Element is=" + min);
        //Console.ReadLine();

        //3 Find Second Largest Elemet in Array

        //int[] arr = { 3,3,9,3,10};
        //int first = int.MinValue;
        //int second = int.MinValue;


        //for(int i = 0; i<arr.Length;i++)
        //{
        //    if (arr[i]>first)
        //    {
        //        second = first;
        //        first = arr[i];
        //    }

        //    else if (arr[i]>second && arr[i]!=first)
        //    {
        //        second = arr[i];

        //    }
        //}
        //if(second == int.MinValue)
        //{
        //    Console.WriteLine("No Second Highest element in array");
        //}
        //else
        //{
        //    Console.WriteLine("Second Largest Element in Array=" + second);
        //}

        //Console.ReadLine();



        // 4 Sort the Array Descending order
        //int[] arr = { 4, 6, 1, 3, 2 };
        //for(int i =0;i<arr.Length;i++)
        //{
        //    for(int j =0;j<arr.Length;j++)
        //    {
        //        if (arr[i] > arr[j])
        //        {
        //            int temp = arr[i];
        //            arr[i] = arr[j];
        //            arr[j] = temp;
        //        }
        //    }

        //}
        //Console.WriteLine("In Descending Order:");
        //foreach (int num in arr)
        //{
        //    Console.Write(" " + num);
        //}

        ////In Ascending Order
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    for (int j = 0; j < arr.Length; j++)
        //    {
        //        if (arr[i] < arr[j])
        //        {
        //            int temp = arr[i];
        //            arr[i] = arr[j];
        //            arr[j] = temp;
        //        }
        //    }

        //}
        //Console.WriteLine("In Ascending Order:");
        //foreach (int num in arr)
        //{
        //    Console.Write(" " + num);
        //}
        //Console.ReadLine();



        // 5 Find Duplicate  Elemnts in array

        //int[] arr = { 1, 2, 2, 3, 5, 6, 6 };
        //for(int i=0;i<arr.Length;i++)
        //{

        //    for(int j =i+1;j<arr.Length;j++)
        //    {
        //        if (arr[i] == arr[j])
        //        {
        //            Console.WriteLine("Duplicate Elements in array"+arr[i]);
        //            break;
        //        }

        //    }


        //}
        //Console.ReadLine();

        // 6 Sum of Given array element

        //int[] arr = { 1, 2, 3, 4, 5, 5 };
        //int sum = 0;

        //for(int i =0;i<arr.Length;i++)
        //{
        //    sum = sum + arr[i];
        //}
        //Console.WriteLine("Addition is :" + sum);

        //Console.ReadLine();

        //// 7 Find Index of a partiular element

        //int[] arr = { 1,5, 3, 4, 5, 6, 7 };
        //int taget = 5;

        //for(int i = 0;i<arr.Length;i++)
        //{
        //    if (arr[i]==taget)
        //    {
        //        Console.Write("Index of :" + taget +" is :"+i);

        //    }
        //}

        //Merge of two array
        //int[] arr = { 1, 2, 3 };
        //int[] arr1 = { 4, 5, 6 };

        //int n1 = arr.Length, n2 = arr1.Length;
        //int[] merge = new int[n1+n2];

        //for(int i =0;i<n1;i++)
        //{
        //    merge[i] = arr[i];
        //}

        //for(int i=0;i<n2;i++)
        //{
        //    merge[n1 + i] = arr1[i];
        //}

        //foreach(int num in merge)
        //{
        //    Console.Write(num);
        //}
        //Console.ReadLine();

        // Remove duplicate elements in sorted array

        int[] arr = { 1, 2, 2, 3, 4, 5, 5 };
        int index = 0;

        for(int i=1;i<arr.Length;i++)
        {
            if (arr[i] != arr[index])
            {
                index++;
                arr[index] = arr[i];
            }
        }
        for(int i=0;i<index;i++)
        {
            Console.Write(arr[i]);
        }
        Console.ReadLine();

        

        

    }
}