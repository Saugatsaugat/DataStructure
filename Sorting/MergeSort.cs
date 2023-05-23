using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSort
{
    public class MergeSort
    {
        public void mergeSort(int[] arr, int l, int r)
        { 
            if (l < r)
            {

                int m = (l + r) / 2;
                mergeSort(arr, l, m);
                mergeSort(arr, m + 1, r);
                merge(arr, l, m, r);
            }
        }
           public void merge(int[] arr, int l, int m, int r)
            {
                int x = l;
                int y = m + 1;
                int k = l;
                int[] B = new int[r+1];

            while (x <= m && y <= r)
                {
                    if (arr[x] <= arr[y])
                    {
                        B[k] = arr[x];
                        x++;
                    }
                    else
                    {
                        B[k] = arr[y];
                        y++;
                    }
                    k++;
                }
                while (x <= m)
                {
                    B[k] = arr[x];
                    x++; k++;
                }
                while (y <= r)
                {
                    B[k] = arr[y];
                    y++; k++;
                }
                for (int i = l; i <k; i++)
                {
                    arr[i] = B[i];
                }
        }
    }
}
