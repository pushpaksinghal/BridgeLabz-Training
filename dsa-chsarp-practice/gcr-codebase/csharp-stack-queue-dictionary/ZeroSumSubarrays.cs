using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stack_queue_dictionary
{
    internal class ZeroSumSubarrays
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 3, -1, -3, 4, -2, 2 };
            FindSubarrays(arr);
        }

        static void FindSubarrays(int[] arr)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            int sum = 0;

            map[0] = new List<int> { -1 };

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (map.ContainsKey(sum))
                {
                    foreach (int start in map[sum])
                        Console.WriteLine("Subarray: "+start + 1+" to "+i);
                }

                if (!map.ContainsKey(sum))
                    map[sum] = new List<int>();

                map[sum].Add(i);
            }
        }
    }

}
