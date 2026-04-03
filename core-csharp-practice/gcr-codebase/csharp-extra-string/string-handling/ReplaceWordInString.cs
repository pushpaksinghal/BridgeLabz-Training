using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.string_handling
{
    internal class ReplaceWordInString
    {
        static void Main(string[] args)
        {
            // input the string , the word to be repalced , the word to replace with
            string s = Console.ReadLine();
            string o = Console.ReadLine();
            string n = Console.ReadLine();
            Console.WriteLine(Rep(s, o, n));
        }
        static string Rep(string s, string o, string n)
        {
            // method to replace the word in a string
            string r = "";
            for (int i = 0; i < s.Length;)
            {
                int j = 0;
                // find the word in the string untill then add char after char in teh result string if found replace teh word
                while (j < o.Length && i + j < s.Length && s[i + j] == o[j])
                {
                    j++;
                }
                if (j == o.Length)
                {
                    r += n; 
                    i += o.Length;
                }
                else
                { 
                    r += s[i];
                    i++;
                }
            }
            return r;
        }
    }
}
