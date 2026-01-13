using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stringbuildle_binarysearch_filereader
{
    internal class LinearAndBinaryChallenge
    {
        static void Main(String[]args)
        {
            int[] arr = { 3, 4, -1, 1 };

            bool[] present = new bool[arr.Length + 1];
            foreach (int n in arr)
            {
                if (n > 0 && n <= arr.Length)
                    present[n] = true;
            }

            for (int i = 1; i < present.Length; i++)
            {
                if (!present[i])
                {
                    Console.WriteLine("Missing: " + i);
                    break;
                }
            }

            Array.Sort(arr);
            int target = 4;
            int index = Array.BinarySearch(arr, target);
            Console.WriteLine(index >= 0 ? index : -1);
        }
    }
}
