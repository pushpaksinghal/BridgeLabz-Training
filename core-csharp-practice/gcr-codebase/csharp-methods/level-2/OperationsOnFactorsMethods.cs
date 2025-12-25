using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_2
{
    internal class OperationsOnFactorsMethods
    {
        static void Main(String[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            OperationsOnFactorsMethods method = new OperationsOnFactorsMethods();
            int lengthofarr = method.Factors(number).Length;
            int[] reFactors = method.Factors(number);

            for (int i = 0; i < lengthofarr; i++)
            {
                Console.Write(reFactors[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(method.SumOfFactors(reFactors));
            Console.WriteLine(method.SumOfSquareFactors(reFactors));
            Console.WriteLine(method.ProductOfFactors(reFactors));

        }
        int[] Factors(int value)
        {
            // Finding factors of a number
            int index = value / 2;
            int[] fact = new int[index];
            int n = 0;
            for (int i = 1; i <= value; i++)
            {
                if (value % i == 0)
                {
                    // Resize the array if needed
                    if (n == index)
                    {
                        index = index * 2;
                        int[] temp = new int[index];
                        for (int j = 0; j < temp.Length; i++)
                        {
                            // Copy old elements to new array
                            temp[j] = fact[i];
                        }
                        fact = temp;
                    }
                    fact[n] = i;
                    n++;

                }
            }

            return fact;
        }

        int SumOfFactors(int[] reFactors)
        {
            //  Sum of factors
            int sum = 0;
            for (int i = 0; i < reFactors.Length; i++)
            {
                sum += reFactors[i];

            }
            return sum;
        }
        int SumOfSquareFactors(int[] reFactors)
        {
            // Sum of square of factors
            int sum2 = 0;
            for (int i = 0; i < reFactors.Length; i++)
            {
                sum2 += reFactors[i] * reFactors[i];

            }
            return sum2;
        }
        int ProductOfFactors(int[] reFactors)
        {
            // Product of factors
            int product = 1;
            for (int i = 0; i < reFactors.Length; i++)
            {
                product *= reFactors[i];

            }
            return product;
        }
    }
}
