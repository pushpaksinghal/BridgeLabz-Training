using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stringbuildle_binarysearch_filereader
{
    internal class RotationPoint_Binary
    {
        static void Main(String[]args)
        {
            int[] arr = { 4, 5, 6, 7, 1, 2, 3 };
            int low = 0, high = arr.Length - 1;

            while (low < high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] > arr[high])
                    low = mid + 1;
                else
                    high = mid;
            }

            Console.WriteLine(low);
        }
    }
}
