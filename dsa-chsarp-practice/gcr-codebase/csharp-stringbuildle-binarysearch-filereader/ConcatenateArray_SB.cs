using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stringbuildle_binarysearch_filereader
{
    internal class ConcatenateArray_SB
    {
        static void Main(String[] args)
        {
            string[] words = { "C#", " ", "is", " ", "fast" };
            StringBuilder sb = new StringBuilder();

            foreach (string word in words)
            {
                sb.Append(word);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
