using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_collections.List_Interface
{
    internal class RotateList
    {
        static void Rotate(List<int> list, int k)
        {
            k = k % list.Count;
            List<int> temp = new List<int>();
            for (int i = k; i < list.Count; i++) temp.Add(list[i]);
            for (int i = 0; i < k; i++) temp.Add(list[i]);
            list.Clear();
            list.AddRange(temp);
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
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            Display(list);
            Console.WriteLine();
            Rotate(list, 3);
            Display(list);
        }
    }
}
