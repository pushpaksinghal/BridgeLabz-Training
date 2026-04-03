using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_1
{
    internal class SumOfNNaturalNumberMethod
    {
        static void Main(String[] args)
        {
            //taking the input from user
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the sum of numbers is " + Sum(number));
        }
        static int Sum(int number)
        {
            //calculating the sum of n natural numbers
            int sum = 0;
            for (int i = 0; i <= number; i++)
            {
                sum = sum + (i + 1);

            }
            return sum;
        }
    }
}
