using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_collections.List_Interface
{
    internal class FindElement
    {
        static string NthFromEnd(LinkedList<string> list, int n)
        {
            var fast = list.First;
            var slow = list.First;


            for (int i = 0; i < n; i++) fast = fast.Next;
            while (fast != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }
            return slow.Value;
        }
        private static void Display(LinkedList<string> list)
        {
            foreach (string i in list)
            {
                Console.Write(i + " ");
            }
        }
        public static void Main(String[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("pushpak");
            list.AddLast("singhal");
            list.AddLast("is");
            list.AddLast("a");
            list.AddLast("good");
            list.AddLast("guy");

            Display(list);
            Console.WriteLine();
            string s = NthFromEnd(list, 3);
            Console.WriteLine(s);
        }

    }
}
