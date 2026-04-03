using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stringbuildle_binarysearch_filereader
{
    internal class FirstLastOccurrence
    {
        static void Main(String[]args)
        {
            int[] arr = { 1, 2, 2, 2, 3, 4 };
            int target = 2;

            int first = -1, last = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    if (first == -1) first = i;
                    last = i;
                }
            }

            Console.WriteLine($"{first}, {last}");
        }
    }
}
