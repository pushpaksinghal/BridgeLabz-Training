using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stack_queue_dictionary
{
    internal class LongestConsecutive
    {
        static void Main(string[] args)
        {
            int[] arr = { 100, 4, 200, 1, 3, 2 };
            Console.WriteLine(FindLongest(arr));
        }

        static int FindLongest(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            int longest = 0;

            foreach (int num in nums)
            {
                if (!set.Contains(num - 1))
                {
                    int current = num;
                    int length = 1;

                    while (set.Contains(current + 1))
                    {
                        current++;
                        length++;
                    }
                    longest = Math.Max(longest, length);
                }
            }
            return longest;
        }
    }

}
