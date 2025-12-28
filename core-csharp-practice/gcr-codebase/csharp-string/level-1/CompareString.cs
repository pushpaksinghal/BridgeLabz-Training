using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_string.level_1
{
    internal class CompareString
    {
        static void Main(String[] args)
        {
            //input two string and checking if they are equal 
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            //making a self method
            bool r1 = Compare(s1, s2);
            bool r2 = string.Equals(s1, s2);
            Console.WriteLine(r1);
            Console.WriteLine(r2);
        }

        static bool Compare(string a, string b)
        {
            //first checking the length
            if (a.Length != b.Length)
            {
                return false;
            }
            // then the letter
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }
    }
}
