using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_string.level_1
{
    internal class ToLowerStringCase
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(Lower(s));
            Console.WriteLine(s.ToLower());
        }

        static string Lower(string s)
        {
            string r = "";
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c>= 'A' && c<= 'Z')
                {
                    c = (char)(c + 32);
                }
                r += c;
            }
            return r;
        }
    }
}
