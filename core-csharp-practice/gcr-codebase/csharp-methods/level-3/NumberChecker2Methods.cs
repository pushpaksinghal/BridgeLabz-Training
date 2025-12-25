using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_3
{
    internal class NumberChecker2Methods
    {
        static void Main(string[] args)
        {
            // Input number from user
            int number = Convert.ToInt32(Console.ReadLine());

            int digitCount = Count(number);
            int[] digits = StoreDigits(number);
            for (int i = 0; i < digits.Length; i++)
            {
                Console.Write(digits[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(" the sum fo digits is " + SumDigit(digits));
            Console.WriteLine("the sum of aqyare of digits is " + SumSquareDigit(digits));
            Console.WriteLine("the number is harshad " + IsHarshad(number, digits));
            int[,] freq = Frequency(digits);
            for (int i = 0; i < digits.Length; i++)
            {
                Console.Write("the " + freq[i, 0] + " has" + freq[i, 1]);
            }
        }
        //methods for some operations
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

        static int SumDigit(int[] digits)
        {
            int sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += digits[i];
            }

            return sum;
        }

        static int SumSquareDigit(int[] digits)
        {
            int sqyareSum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sqyareSum += digits[i] * digits[i];
            }

            return sqyareSum;
        }

        static bool IsHarshad(int number, int[] digits)
        {
            int sum = SumDigit(digits);
            return number % sum == 0;
        }

        static int[,] Frequency(int[] digits)
        {
            int[,] freq = new int[digits.Length, 2];

            for (int i = 0; i < digits.Length; i++)
            {
                freq[i, 0] = i;
                freq[i, 1] = 0;
            }

            for (int i = 0; i < digits.Length; i++)
            {
                freq[digits[i], 1]++;
            }

            return freq;
        }


    }
}
