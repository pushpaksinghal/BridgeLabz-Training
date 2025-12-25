using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_2
{
    internal class SumOfNaturalRecursion
    {
        static void Main(String[] arggs)
        {
            // Sum of n natural numbers using recursion
            int number = Convert.ToInt32(Console.ReadLine());
            SumOfNaturalRecursion method = new SumOfNaturalRecursion();
            int formula = (number * (number + 1)) / 2;
            if (formula == method.RecursionSum(number))
            {
                Console.WriteLine("both are equals");
            }
            else
            {
                Console.WriteLine("not equal");
            }

        }

        int RecursionSum(int value)
        {
            // Base case
            if (value == 1)
            {
                return 1;
            }
            else
            {
                // Recursive case
                return value + RecursionSum(value - 1);
            }


        }
    }
}
