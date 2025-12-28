using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.string_handling
{
    internal class RemoveALetter
    {
        static void Main(string[] args)
        {
            // input teh string 
            string s = Console.ReadLine();
            char r = Console.ReadLine()[0];
            string o = "";
            // removethe letter from a string by treversing
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != r)
                {
                    o += s[i];
                }
            }
            Console.WriteLine(o);
        }
    }
}
