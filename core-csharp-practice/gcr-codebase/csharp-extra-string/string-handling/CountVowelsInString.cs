using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.string_handling
{
    internal class CountVowelsInString
    {
        static void Main(string[] args)
        {
            //input the string
            string s = Console.ReadLine();
            int vowels = 0, consonent = 0;
            // if it is a char then check if it is a vowel or not and increase the count
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if ((ch>='a'&&ch<='z')||(ch>='A'&&ch<='Z'))
                {
                    if (ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u'||ch=='A'||ch=='E'||ch== 'I'||ch=='O'|| ch=='U')
                    {
                        vowels++;
                    }
                    else
                    {
                        consonent++;
                    }
                }
            }
            Console.WriteLine(vowels);
            Console.WriteLine(consonent);
        }
    }
}
