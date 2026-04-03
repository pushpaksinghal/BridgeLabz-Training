using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stack_queue_dictionary
{
    internal class QueuefromStack
    {
        static void Main(string[] args)
        {
            QueuefromStack q1 = new QueuefromStack();
            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue(3);
            q1.Enqueue(4);
            q1.Enqueue(5);
            Console.WriteLine(q1.Dequeue());
        }
        private Stack<int> first = new Stack<int>();
        private Stack<int> last = new Stack<int>();

        public void Enqueue(int x)
        {
            first.Push(x);
        }

        public int Dequeue()
        {
            if (last.Count == 0)
            {
                while (first.Count > 0)
                {
                    last.Push(first.Pop());
                }
            }
            if (last.Count == 1)
            {
                Console.WriteLine("queue is empty");
            }
            return last.Pop();
        }

    }
}
