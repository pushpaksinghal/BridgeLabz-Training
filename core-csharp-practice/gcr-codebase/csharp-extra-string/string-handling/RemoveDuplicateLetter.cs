using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.string_handling
{
    internal class RemoveDuplicateLetter
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string r = "";
            for (int i = 0; i < s.Length; i++)
            {
                bool f = false;
                for (int j = 0; j < r.Length; j++)
                {
                    if (s[i] == r[j])
                    {
                        f = true;
                    }
                }
                if (!f){
                    r += s[i];
                }
            }
            Console.WriteLine(r);
        }
    }
}
