using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stack_queue_dictionary
{
    internal class PairWithSum
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 7, 2, 5, 3, 1 };
            int target = 10;

            Console.WriteLine(HasPair(arr, target));
        }

        static bool HasPair(int[] arr, int target)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int num in arr)
            {
                if (set.Contains(target - num))
                    return true;
                set.Add(num);
            }
            return false;
        }
    }

}
