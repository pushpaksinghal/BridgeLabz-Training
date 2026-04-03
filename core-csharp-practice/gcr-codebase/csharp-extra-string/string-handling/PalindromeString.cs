using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.string_handling
{
    internal class PalindromeString
    {
        // inpu the string 
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int i = 0;
            // check the string from front and back if the letter are equal
            int j = s.Length - 1;
            bool f = true;
            while (i < j)
            {
                if (s[i]!=s[j])
                {
                    f = false;
                    break;
                }
                i++;
                j--;
            }
            Console.WriteLine(f);
        }
    }
}
