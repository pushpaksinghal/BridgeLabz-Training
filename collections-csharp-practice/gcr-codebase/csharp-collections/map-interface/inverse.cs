using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_collections.map_interface
{
    internal class inverse
    {
        static Dictionary<int, List<string>> Invert(Dictionary<string, int> map)
        {
            Dictionary<int, List<string>> result = new Dictionary<int, List<string>>();
            foreach (var kv in map)
            {
                if (!result.ContainsKey(kv.Value))
                    result[kv.Value] = new List<string>();
                result[kv.Value].Add(kv.Key);
            }
            return result;
        }

        public static void Main(string[] args)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("A", 1);
            d.Add("B", 2);
            d.Add("C", 1);
            d.Add("D", 3);

            Dictionary<int, List<string>> q = Invert(d);

        }
    }
}
