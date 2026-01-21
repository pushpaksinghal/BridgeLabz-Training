using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_collections.List_Interface
{
    internal class RemoveDupliactes
    {
        static List<int> RemoveDuplicates(List<int> list)
        {
            HashSet<int> seen = new HashSet<int>();
            List<int> result = new List<int>();
            foreach (int x in list)
                if (seen.Add(x)) result.Add(x);
            return result;
        }
        static void Display(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }

        public static void Main(String[] args)
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(1);
            list.Add(3);
            list.Add(2);
            list.Add(1);

            Display(list);
            Console.WriteLine();
            list = RemoveDuplicates(list);
            Display(list);
        }
    }
}
