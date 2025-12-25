using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_3
{
    internal class NumberCheckerMethids
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

            Console.WriteLine("Duck Number: " + (IsDuck(digits) ? "Yes" : "No"));
            Console.WriteLine("Armstrong Number: " + (IsArmstrong(number, digits) ? "Yes" : "No"));

            int[] largerstAndSecond = FindLAndSL(digits);
            int[] smalllestAndSecond = FindSAndSS(digits);

            Console.WriteLine("Largest " + largerstAndSecond[0] + "second largest " + largerstAndSecond[1] + " smallest " + smalllestAndSecond[0] + " second smallet " + smalllestAndSecond[1]);
        }

        //methods on a number
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
        static bool IsDuck(int[] digits)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] != 0)
                    return true;
            }
            return false;
        }
        static bool IsArmstrong(int number, int[] digits)
        {
            int power = digits.Length;
            int sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                sum += (int)Math.Pow(digits[i], power);
            }

            return sum == number;
        }
        static int[] FindLAndSL(int[] digits)
        {
            int largest = 0;
            int secondLargest = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] > largest)
                {
                    secondLargest = largest;
                    largest = digits[i];
                }
                else if (digits[i] > secondLargest && digits[i] != largest)
                {
                    secondLargest = digits[i];
                }
            }
            return new int[] { largest, secondLargest };
        }
        static int[] FindSAndSS(int[] digits)
        {
            int smallest = digits[0];
            int secondSmallest = digits[0];

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = digits[i];
                }
                else if (digits[i] < secondSmallest && digits[i] != smallest)
                {
                    secondSmallest = digits[i];
                }
            }
            return new int[] { smallest, secondSmallest };
        }
    }
}
