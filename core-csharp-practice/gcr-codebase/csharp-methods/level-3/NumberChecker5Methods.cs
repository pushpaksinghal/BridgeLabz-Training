using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_3
{
    internal class NumberChecker5Methods
    {
        static void Main(string[] args)
        {
            // Input number from user
            int number = Convert.ToInt32(Console.ReadLine());

            int factorCount = Count(number);
            int[] Factor = Factors(number);
            for (int i = 0; i < Factor.Length; i++)
            {
                Console.Write(Factor[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("greatest Factor" + GreatestFactor(Factor));
            Console.WriteLine("sum of Factor " + SumFactor(Factor));
            Console.WriteLine("product of Factor" + ProductFactor(Factor));
            Console.WriteLine("product of Cube " + ProductCubeFactor(Factor));
            Console.WriteLine("perfect No. " + IsPerfect(number));
            Console.WriteLine("abundant No " + IsAbundant(number));
            Console.WriteLine("deficient No." + IsDeficient(number));
            Console.WriteLine("strong No. " + IsStrong(number));
        }
        //methods for some operations
        static int Count(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    count++;
            }
            return count;
        }

        static int[] Factors(int number)
        {
            int count = Count(number);
            int[] Factor = new int[count];
            int j = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    Factor[j++] = i;
            }
            return Factor;
        }

        static int GreatestFactor(int[] factors)
        {
            return factors[factors.Length - 1];
        }

        static int SumFactor(int[] Factor)
        {
            int sum = 0;
            for (int i = 0; i < Factor.Length; i++)
            {
                sum += Factor[i];
            }

            return sum;
        }

        static int ProductFactor(int[] Factor)
        {
            int Product = 0;
            for (int i = 0; i < Factor.Length; i++)
            {
                Product *= Factor[i];
            }

            return Product;
        }

        static int ProductCubeFactor(int[] Factor)
        {
            int Product = 0;
            for (int i = 0; i < Factor.Length; i++)
            {
                Product *= Factor[i] * Factor[i] * Factor[i];
            }

            return Product;
        }
        static bool IsPerfect(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            return sum == number;
        }

        static bool IsAbundant(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            return sum > number;
        }

        static bool IsDeficient(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            return sum < number;
        }

        static bool IsStrong(int number)
        {
            int temp = number;
            int sum = 0;

            while (temp != 0)
            {
                int digit = temp % 10;
                sum += Factorial(digit);
                temp /= 10;
            }

            return sum == number;
        }

        static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact *= i;
            return fact;
        }

    }
}
