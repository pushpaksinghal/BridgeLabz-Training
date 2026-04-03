using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stringbuildle_binarysearch_filereader
{
    internal class FirstNegative_Linear
    {
        static void Main()
        {
            int[] arr = { 5, 3, -2, 7, -1 };

            foreach (int n in arr)
            {
                if (n < 0)
                {
                    Console.WriteLine(n);
                    break;
                }
            }
        }
    }
}
