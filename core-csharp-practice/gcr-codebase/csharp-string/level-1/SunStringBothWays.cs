using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_string.level_1
{
    internal class SunStringBothWays
    {
        static void Main(String[] args)
        {
            // input a string and teh index for substring
            string s = Console.ReadLine();
            int st= int.Parse(Console.ReadLine());
            int en= int.Parse(Console.ReadLine());
            // making a self methods to do it
            string r1 = MakeSub(s, st, en);
            string r2 = s.Substring(st, en - st);
            Console.WriteLine(r1);
            Console.WriteLine(r2);
        }

        static String MakeSub(string s, int st, int en)
        {
            string r= "";
            for (int i=st; i<en; i++)
            {
                r+=s[i];
            }
            return r;
        }
    }
}
