using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_2
{
    internal class CompareOnNumberLineMethod
    {
        static void Main(String[] args)
        {
            // Taking 5 numbers as input from user
            int[] number = new int[5];
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Creating object of class to call non
            CompareOnNumberLineMethod method = new CompareOnNumberLineMethod();
            String[] status = method.IsPositiveNegativeZero(number);
            String[] finalStatus = method.IsEvenOrOdd(number, status);
            /// Printing the final status of each number
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("the number " + number[i] + "is " + finalStatus[i]);
            }
            Console.WriteLine(method.WhoIsGreater(number[0], number[4]));
        }

        String[] IsPositiveNegativeZero(int[] number)
        {
            // Determine if each number is positive, negative, or zero
            String[] status = new string[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > 0)
                {
                    status[i] = "Positive";
                }
                else if (number[i] < 0)
                {
                    status[i] = "Negative";
                }
                else
                {
                    status[i] = "Zero";
                }
            }
            return status;
        }

        String[] IsEvenOrOdd(int[] number, String[] status)
        {
            // For positive numbers, determine if they are even or odd
            for (int i = 0; i < number.Length; i++)
            {
                if (status[i] == "Positive")
                {
                    if (number[i] % 2 == 0)
                    {
                        status[i] = "Positive Even";
                    }
                    else
                    {
                        status[i] = "Positive Odd";
                    }
                }
            }
            return status;
        }

        String WhoIsGreater(int number1, int number2)
        {
            // Compare two numbers and return which one is greater or if they are equal
            if (number1 > number2)
            {
                return "First is Greater";
            }
            else if (number1 < number2)
            {
                return "Second is Greater";
            }
            else
            {
                return "Both are Equal";
            }
        }
    }
}
