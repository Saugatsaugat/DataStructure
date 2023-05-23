using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSort
{
    class SelectionSort
    {
        public void selectionSort(int[] arr)
        {
            int n = arr.Length;
            for(int i = 0; i < n; i++)
            {
                int least = arr[i];
                int p = i;
                for(int j = i + 1; j < n; j++)
                {
                    if (arr[j] < least)
                    {
                        least = arr[j];
                        p = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[p];
                arr[p] = temp;

            }
        }
    }
}
