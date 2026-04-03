using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_string.level_1
{
    internal class ToUpperCaseString
    {
        static void Main(string[] args)
        {
            // same making it upper case
            string s = Console.ReadLine();
            Console.WriteLine(Upper(s));
            Console.WriteLine(s.ToUpper());
        }

        static string Upper(string s)
        {
            string r = "";
            for (int i=0;i<s.Length;i++)
            {
                char c = s[i];
                if (c>= 'a' &&c<= 'z')
                {
                    c = (char)(c - 32);
                }
                r += c;
            }
            return r;
        }
    }
}
