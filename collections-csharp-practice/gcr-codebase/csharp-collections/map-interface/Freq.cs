using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_collections.map_interface
{
    internal class Freq
    {
        public static void Main(string[] args)
        {
            string text = "Hello world, hello Java!".ToLower();
            char[] sep = { ' ', ',', '!' };
            string[] words = text.Split(sep, StringSplitOptions.RemoveEmptyEntries);


            Dictionary<string, int> freq = new Dictionary<string, int>();
            foreach (string w in words)
            {
                if (freq.ContainsKey(w)) freq[w]++;
                else freq[w] = 1;
            }
        }
    }
}
