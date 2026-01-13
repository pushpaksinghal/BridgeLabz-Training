using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stringbuildle_binarysearch_filereader
{
    internal class StringBuilderPerformance
    {
        static void Main(String[] args)
        {
            int iterations = 100000;

            Stopwatch sw = Stopwatch.StartNew();
            string s = "";
            for (int i = 0; i < iterations; i++)
                s += "a";
            sw.Stop();
            Console.WriteLine("String time: " + sw.ElapsedMilliseconds);

            sw.Restart();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iterations; i++)
                sb.Append("a");
            sw.Stop();
            Console.WriteLine("StringBuilder time: " + sw.ElapsedMilliseconds);
        }
    }
}
