using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_3
{
    internal class NumberChecker4Methods
    {

        static void Main(string[] args)
        {
            // Taking input from user
            int number = Convert.ToInt32(Console.ReadLine());

            int digitCount = Count(number);
            int[] digits = StoreDigits(number);
            for (int i = 0; i < digits.Length; i++)
            {
                Console.Write(digits[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("prime" + IsPrime(number));
            Console.WriteLine("neon " + IsNeon(number));
            Console.WriteLine("spy " + IsSpy(number));
            Console.WriteLine("automriophic" + IsAutomorphic(number));
            Console.WriteLine("buz " + IsBuzz(number));

        }

        //methods on number 
        static int Count(int number)
        {
            if (number == 0) return 1;

            int count = 0;
            while (number != 0)
            {
                count++;
                number /= 10;
            }
            return count;
        }

        static int[] StoreDigits(int number)
        {
            int count = Count(number);
            int[] digits = new int[count];

            for (int i = count - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }
            return digits;
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsNeon(int number)
        {
            int square = number * number;
            int sum = 0;
            while (square != 0)
            {
                sum += square % 10;
                square /= 10;
            }
            return sum == number;
        }

        static bool IsSpy(int number)
        {
            int sum = 0;
            int product = 1;
            while (number != 0)
            {
                sum += number % 10;
                product *= number % 10;
                number /= 10;
            }
            return sum == product;
        }

        static bool IsAutomorphic(int number)
        {
            int square = number * number;
            int lastDigit = square % 10;
            return lastDigit == number;
        }

        static bool IsBuzz(int number)
        {
            return number % 7 == 0 || number % 10 == 7;
        }
    }
}
