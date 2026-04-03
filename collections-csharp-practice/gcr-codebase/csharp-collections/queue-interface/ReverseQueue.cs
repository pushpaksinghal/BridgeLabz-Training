using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_collections.queue_interface
{
    internal class ReverseQueue
    {
        static void Reverse(Queue<int> q)
        {
            if (q.Count == 0) return;
            int x = q.Dequeue();
            Reverse(q);
            q.Enqueue(x);
        }

        public static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);

            Reverse(q);
        }
    }
}
