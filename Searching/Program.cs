using System;

namespace Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Searching Algorithm ###");
            Console.WriteLine("How many items to keep in array?");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Enter {n} elements");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        
            Console.WriteLine("Enter the Key value to be searched");
            int key = int.Parse(Console.ReadLine());

            //Switch Opearation
            Console.WriteLine("Choose the searching algorithm\n1. LinearSearch\n2. BinarySearch");
            int choose = int.Parse(Console.ReadLine());
            int status = 0;
            switch (choose)
            {
                case 1:
                    status = new LinearSearch().linearSearch(arr, key);
                    break;
                case 2:
                    status = new BinarySearch().binarySearch(arr, 0, n - 1, key);
                    break;
                default:
                    break;

            }

            //condition check
            if (status == 1)
            {
                Console.WriteLine($"key {key} found successfully.");
            }
            else
            {
                Console.WriteLine($"key {key} NOT FOUND!!!");
            }


            
        }
    }
}
