using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_3
{
    internal class NumberChecker3Methods
    {
        static void Main(string[] args)
        {
            //taking input from user
            int number = Convert.ToInt32(Console.ReadLine());

            int digitCount = Count(number);
            int[] digits = StoreDigits(number);
            for (int i = 0; i < digits.Length; i++)
            {
                Console.Write(digits[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Palindrome: " + IsPalindrome(number));
            Console.WriteLine("Duck Number: " + IsDuck(number));
        }
        //methods for some operations on the number
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

        static int[] Reverse(int[] number)
        {
            int[] rev = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                rev[i] = number[number.Length - 1 - i];
            }
            return rev;
        }

        static bool Compare(int[] a, int[] b)
        {
            if (a.Length != b.Length) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }
        static bool IsPalindrome(int number)
        {
            int[] digits = StoreDigits(number);
            int[] reversed = Reverse(digits);
            return Compare(digits, reversed);
        }

        static bool IsDuck(int number)
        {
            int[] digits = StoreDigits(number);
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] != 0)
                    return true;
            }
            return false;
        }
    }
}
