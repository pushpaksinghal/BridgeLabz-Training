using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stack_queue_dictionary
{
    internal class SlidingWindowMaximum
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;
            PrintMax(arr, k);
        }

        static void PrintMax(int[] arr, int k)
        {
            LinkedList<int> dq = new LinkedList<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (dq.Count > 0 && dq.First.Value <= i - k)
                    dq.RemoveFirst();

                while (dq.Count > 0 && arr[dq.Last.Value] < arr[i])
                    dq.RemoveLast();

                dq.AddLast(i);

                if (i >= k - 1)
                    Console.WriteLine(arr[dq.First.Value]);
            }
        }
    }

}
