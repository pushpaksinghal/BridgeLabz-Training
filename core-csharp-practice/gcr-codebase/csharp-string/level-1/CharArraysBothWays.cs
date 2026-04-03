using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_string.level_1
{
    internal class CharArraysBothWays
    {
        static void Main(String[] args)
        {
            //taking input of string
            String s = Console.ReadLine();
            //creating a method for making an array and using inbuid method
            char[] a1 = GetChars(s);
            char[] a2 = s.ToCharArray();
            //printing them
            for (int i = 0; i < a1.Length; i++)
            {
                Console.Write(a1[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < a2.Length; i++)
            {
                Console.Write(a2[i]+" ");
            }
        }

        static char[] GetChars(string s)
        {
            char[] a = new char[s.Length];
            for (int i=0; i<s.Length; i++)
            {
                a[i] = s[i];
            }
            return a;
        }
    }
}
