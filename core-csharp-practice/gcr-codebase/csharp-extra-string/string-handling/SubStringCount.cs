using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.string_handling
{
    internal class SubStringCount
    {
        static void Main(string[] args)
        {
            // input eh string and the sub string to find the count of 
            string s = Console.ReadLine();
            string sub = Console.ReadLine();
            int c = 0;
            // go through the string to find the substring and increase the count
            for (int i = 0; i<=s.Length-sub.Length;i++)
            {
                int j = 0;
                while (j < sub.Length && s[i + j] == sub[j])
                {
                    j++;
                }
                if (j == sub.Length)
                {
                    c++;
                }
            }
            Console.WriteLine(c);
        }
    }
}
