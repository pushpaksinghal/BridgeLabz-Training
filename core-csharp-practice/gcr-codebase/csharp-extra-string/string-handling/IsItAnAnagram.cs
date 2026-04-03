using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.string_handling
{
    internal class IsItAnAnagram
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if (a.Length != b.Length)
            {
                Console.WriteLine(false);
                return;
            }
            bool f = true;
            for (int i = 0; i < a.Length; i++)
            {
                int ca = 0, cb = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j]) ca++;
                    if (a[i] == b[j]) cb++;
                }
                if (ca != cb)
                {
                    f = false; 
                    break;
                }
            }
            Console.WriteLine(f);
        }
    }
}
