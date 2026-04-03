using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stringbuildle_binarysearch_filereader
{
    internal class SentenceSearch_Linear
    {
        static void Main(String[]args)
        {
            string[] sentences ={"Csharp eafg","Java bsrgesrb","Python rgegsfbv"};
            string word = "Python";

            foreach (string s in sentences)
            {
                if (s.Contains(word))
                {
                    Console.WriteLine(s);
                    break;
                }
            }
        }
    }
}
