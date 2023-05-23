using System;

namespace bubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Sorting Algorithms Implementation");
            Console.WriteLine("How many elements you want to enter?");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine($"Enter {n} items");
            for(int i=0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Before Sort");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nChoose the sorting algorithm\n1. BubbleSort\n2. SelectionSort\n3. InsertionSort\n4. MergeSort\n5. QuickSort");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    new Bubble().bubbleSort(arr);
                    break;
                case 2:
                    new SelectionSort().selectionSort(arr);
                    break;
                case 3:
                    new InsertionSort().insertionSort(arr);
                    break;
                case 4:
                    new MergeSort().mergeSort(arr, 0, n-1);
                    break;
                case 5:
                    new QuickSort().quickSort(arr, 0, n - 1);
                    break;

                default:
                    break;
            }

           
            Console.WriteLine("\nAfter Sorting");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
        }

        
    }
}
