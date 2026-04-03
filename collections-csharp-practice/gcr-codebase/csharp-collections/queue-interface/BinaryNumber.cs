using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_collections.queue_interface
{
    internal class BinaryNumber
    {
        static void GenerateBinary(int n)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("1");


            for (int i = 0; i < n; i++)
            {
                string s = q.Dequeue();
                Console.WriteLine(s);
                q.Enqueue(s + "0");
                q.Enqueue(s + "1");
            }
        }
        public static void Main(string[] args)
        {
            GenerateBinary(5);
        }
    }
}
