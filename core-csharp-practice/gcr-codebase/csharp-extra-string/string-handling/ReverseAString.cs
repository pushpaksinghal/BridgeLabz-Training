using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.string_handling
{
    internal class ReverseAString
    {
        static void Main(string[] args)
        {
            // input the string 
            string s=Console.ReadLine();
            string r = "";
            // reversing the strng
            for (int i = s.Length - 1; i >= 0; i--)
            {
                r += s[i];
            }
            Console.WriteLine(r);
        }
    }
}
