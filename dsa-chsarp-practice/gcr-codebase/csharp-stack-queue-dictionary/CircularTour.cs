    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stack_queue_dictionary
{
    internal class CircularTour
    {
        static void Main(string[] args)
        {
            int[] petrol = { 6, 3, 7 };
            int[] distance = { 4, 6, 3 };

            Console.WriteLine(FindStart(petrol, distance));
        }

        static int FindStart(int[] petrol, int[] distance)
        {
            int start = 0, balance = 0, deficit = 0;

            for (int i = 0; i < petrol.Length; i++)
            {
                balance += petrol[i] - distance[i];
                if (balance < 0)
                {
                    start = i + 1;
                    deficit += balance;
                    balance = 0;
                }
            }
            return (balance + deficit >= 0) ? start : -1;
        }
    }

}
