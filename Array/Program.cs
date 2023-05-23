using System;

namespace oneDArray
{
    class Program
    {
        public void example()
        {

            Console.WriteLine("How many elements you want to add?");
            int n = Convert.ToInt32(Console.ReadLine());

            //Array Initilization
            int[] number = new int[n];

            //Getting the inputs
            Console.WriteLine("Enter the "+n+" elements");
            for (int i = 0; i < n; i++)
            {              
              number[i] = int.Parse(Console.ReadLine());              
            }

            //Finding the length of an array
            int length = number.Length;
            Console.WriteLine("Number of Elements in an array is: " + length);

            //Displaying all the elements in the array number using foreach loop.
            Console.WriteLine("The elements in the array are");
            foreach(int item in number)
            {
                Console.Write(item+" ");
            }

            //Accessing the specific element
            Console.WriteLine("\nElement at position 1 is: " + number[0]);

            //Sorting the given number 
            Console.WriteLine("Before Sort");
            foreach (int item in number)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("\nAfter Sort");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    if (number[j] > number[j + 1])
                    {
                        int temp = number[ j+ 1];
                        number[j + 1] = number[j];
                        number[j] = temp;
                    }
                }
            }

            foreach (int item in number)
            {
                Console.Write(item+" ");
            }
            

        }
        static void Main(string[] args)
        {
            var oj = new Program();
            oj.example();
        }
    }
}
