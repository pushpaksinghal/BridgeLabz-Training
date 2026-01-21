using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_collections.queue_interface
{
    internal class priorityQueue
    {
        public static void Main(string[] args)
        {
            PriorityQueue<string, int> pq = new PriorityQueue<string, int>();
            pq.Enqueue("John", -3);
            pq.Enqueue("Alice", -5);
            pq.Enqueue("Bob", -2);


            while (pq.Count > 0)
                Console.WriteLine(pq.Dequeue());
        }
    }
}
