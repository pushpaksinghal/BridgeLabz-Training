using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.csharp_built_in_function
{
    internal class MaxOfThree
    {
        static void Main(string[] args)
        {
            int a = Input();
            int b = Input();
            int c = Input();
            Console.WriteLine(Max(a, b, c));
        }
        static int Input()
        {
            return int.Parse(Console.ReadLine());
        }
        static int Max(int a, int b, int c)
        {
            int m = a;
            if (b > m) m = b;
            if (c > m) m = c;
            return m;
        }
    }
}
