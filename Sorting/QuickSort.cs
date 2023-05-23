using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSort
{
    class QuickSort
    {
        public void quickSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int p = partition(arr, l, r);
                quickSort(arr, l, p - 1);
                quickSort(arr, p + 1, r);
            }
        }
        public int partition(int[] arr, int l, int r)
        {
            int x = l;
            int y = r;
            int pivot = arr[l];
            while (x < y)
            {
                while (arr[x] <= pivot)
                {
                    x++;
                }
                while (arr[y] > pivot)
                {
                    y--;
                }
                if (x < y)
                {
                    int temp = arr[x];
                    arr[x] = arr[y];
                    arr[y] = temp;
                }
            }
            arr[l] = arr[y];
            arr[y] = pivot;
            return y;
        }
    }
}
