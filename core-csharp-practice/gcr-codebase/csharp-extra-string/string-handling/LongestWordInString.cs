using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.string_handling
{
    internal class LongestWordInString
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string w = "";
            string lw = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    if (w.Length > lw.Length)
                    {
                        lw = w;
                    }
                    w = "";
                }
                else w += s[i];
            }
            if (w.Length > lw.Length) lw = w;
            Console.WriteLine(lw);
        }
    }
}
