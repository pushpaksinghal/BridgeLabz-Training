using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.string_handling
{
    internal class ToggleCaseString
    {
        static void Main(string[] args)
        {
            // input the string
            string s = Console.ReadLine();
            string r = "";
            // if the char is lower case the change it to upper case and vise versa
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c >= 'a' && c <= 'z')
                {
                    c = (char)(c - 32);
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    c = (char)(c + 32);
                }
                r += c;
            }
            Console.WriteLine(r);
        }
    }
}
