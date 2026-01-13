using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stringbuildle_binarysearch_filereader
{
    internal class PeakElement_Binary
    {
        static void Main(String[]args)
        {
            int[] arr = { 1, 3, 20, 4, 1 };
            int low = 0, high = arr.Length - 1;

            while (low < high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] < arr[mid + 1])
                    low = mid + 1;
                else
                    high = mid;
            }

            Console.WriteLine(arr[low]);
        }
    }
}
