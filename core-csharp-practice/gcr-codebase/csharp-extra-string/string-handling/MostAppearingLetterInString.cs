using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.string_handling
{
    internal class MostAppearingLetterInString
    {
        static void Main(string[] args)
        {
            //  input the string
            string s = Console.ReadLine();
            char m = ' ';
            int mc = 0;
            // checkingthe letter which appere most in a string
            for (int i = 0; i < s.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        c++;
                    }
                }
                if (c > mc)
                {
                    mc = c;
                    m = s[i];
                }
            }
            Console.WriteLine(m);
        }
    }
}
