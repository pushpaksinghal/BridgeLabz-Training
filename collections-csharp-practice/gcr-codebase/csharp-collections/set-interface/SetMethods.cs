using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_collections.set_interface
{
    internal class SetMethods
    {
        public static void Main(String[] args)
        {
            HashSet<int> first = new HashSet<int>();
            first.Add(1);
            first.Add(3);
            first.Add(4);
            first.Add(5);

            HashSet<int> second = new HashSet<int>();
            second.Add(1);
            second.Add(2);
            second.Add(4);
            second.Add(6);
            Display(first);
            Console.WriteLine();
            Display(second);
            Console.WriteLine();

            bool equal = first.SetEquals(second);

            Console.WriteLine(equal);

            HashSet<int> union = new HashSet<int>(first);
            union.UnionWith(second);
            Display(union);
            Console.WriteLine();


            HashSet<int> intersection = new HashSet<int>(first);
            intersection.IntersectWith(second);
            Display(intersection);
            Console.WriteLine();

            HashSet<int> diff = new HashSet<int>(first);
            diff.SymmetricExceptWith(second);
            Display(diff);
            Console.WriteLine();

            List<int> sorted = new List<int>(union);
            sorted.Sort();
            Display(sorted);
            Console.WriteLine();

            bool isSubset = first.IsSupersetOf(intersection);
            Console.WriteLine(isSubset);


        }

        static void Display(HashSet<int> list)
        {
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }

        static void Display(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }
    }
}
