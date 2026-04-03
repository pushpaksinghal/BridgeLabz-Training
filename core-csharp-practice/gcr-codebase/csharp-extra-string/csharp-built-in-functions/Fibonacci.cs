using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.csharp_built_in_function
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            // input the number
            int n = Convert.ToInt32(Console.ReadLine());
            Fib(n);
        }
        static void Fib(int n)
        {
           // printing the fib till that number
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a);
                int c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
