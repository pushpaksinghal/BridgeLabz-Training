using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_string.level_1
{
    internal class DisplayWordLengthString
    {
        static void Main(string[] args)
        {
            //input the String
            string s=Console.ReadLine();
            string word="";
            // for every word in a string  count the letter using the method
            for (int i=0;i<s.Length;i++)
            {
                if (s[i]==' ')
                {
                    Console.WriteLine(word + " " + Len(word));
                    word="";
                }
                else word+=s[i];
            }
            Console.WriteLine(word + " " + Len(word));
        }

        static int Len(string s)
        {
            int c = 0;
            for(int i = 0; i < s.Length; i++)
            {
                c++;
            }
            return c;
        }
    }
}
