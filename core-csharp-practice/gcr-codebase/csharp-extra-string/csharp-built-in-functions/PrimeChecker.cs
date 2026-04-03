using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.csharp_built_in_function
{
    internal class PrimeChecker
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }
        static bool IsPrime(int n)
        {
            if (n<=1)
            {
                return false;
            }
            for (int i=2; i*i<= n; i++)
            {
                if (n%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
