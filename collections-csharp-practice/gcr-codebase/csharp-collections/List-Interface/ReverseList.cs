using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_collections.List_Interface
{
    internal class ReverseList
    {
        static void ReverseArrayList(ArrayList list)
        {
            int i = 0, j = list.Count - 1;
            while (i < j)
            {
                object temp = list[i];
                list[i] = list[j];
                list[j] = temp;
                i++; j--;
            }
        }


        static void ReverseLinkedList(LinkedList<int> list)
        {
            var left = list.First;
            var right = list.Last;
            for (int i = 0; i < list.Count / 2; i++)
            {
                int temp = left.Value;
                left.Value = right.Value;
                right.Value = temp;
                left = left.Next;
                right = right.Previous;
            }
        }

        private static void Display(ArrayList arr)
        {
            foreach (object i in arr)
            {
                Console.Write(i + " ");
            }
        }

        private static void Display(LinkedList<int> list)
        {
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }
        public static void Main(String[] args)
        {
            ArrayList arrList = new ArrayList();

            arrList.Add(1);
            arrList.Add(2);
            arrList.Add(3);
            arrList.Add(4);
            arrList.Add(5);

            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);
            Display(arrList);
            Console.WriteLine();
            Display(linkedList);
            Console.WriteLine();

            ReverseArrayList(arrList);
            ReverseLinkedList(linkedList);

            Display(arrList);
            Console.WriteLine();
            Display(linkedList);

        }
    }
}
