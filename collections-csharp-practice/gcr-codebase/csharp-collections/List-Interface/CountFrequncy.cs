using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_collections.List_Interface
{
    internal class CountFrequncy
    {
        static Dictionary<string, int> GetFrequency(List<string> items)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach (string item in items)
            {
                if (map.ContainsKey(item)) map[item]++;
                else map[item] = 1;
            }
            return map;
        }
        static void Display(List<string> list)
        {
            foreach (string i in list)
            {
                Console.Write(i + " ");
            }
        }
        static void Display(Dictionary<string, int> list)
        {
            foreach (var i in list)
            {
                Console.WriteLine(i.Key + ": " + i.Value);
            }
        }

        public static void Main(String[] args)
        {
            List<String> items = new List<string>();
            items.Add("apple");
            items.Add("banana");
            items.Add("orange");
            items.Add("apple");
            items.Add("banana");
            Display(items);
            Console.WriteLine();
            Dictionary<string, int> itmscount = GetFrequency(items);
            Display(itmscount);
        }
    }
}
