using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class BinarySearch
    {
        public int binarySearch(int[] arr, int l, int r, int key)
        {
            if (l == r)
            {
                if (arr[l] == key)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                int m = (l + r) / 2;
                if (arr[m] == key)
                {
                    return 1;
                }
                else if (arr[m] > key)
                {
                   return binarySearch(arr, l, m - 1, key);
                }
                else
                {
                   return binarySearch(arr, m + 1, r, key);
                }
            }            
        }
    }
}
