using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stringbuildle_binarysearch_filereader
{
    internal class RemoveDuplicates_SB
    {
        static void Main(String[] args)
        {
            string input = "programming";
            HashSet<char> seen = new HashSet<char>();
            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                if (seen.Add(c))
                {
                    sb.Append(c);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
