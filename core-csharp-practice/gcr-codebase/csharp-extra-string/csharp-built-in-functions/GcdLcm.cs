using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.csharp_built_in_function
{
    internal class GcdLcm
    {
        static void Main(string[] args)
        {
            // input number
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int g = Gcd(a, b);
            int l = Lcm(a, b, g);
            Console.WriteLine(g);
            Console.WriteLine(l);
        }
        // taking gcd and lcm of the number
        static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }
        static int Lcm(int a, int b, int g)
        {
            return (a * b) / g;
        }
    }
}
