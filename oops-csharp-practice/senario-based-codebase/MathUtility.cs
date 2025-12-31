using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//. Scenario: You are tasked with creating a utility class for mathematical operations.
//Implement the following functionalities using separate methods:
//● A method to calculate the factorial of a number.
//● A method to check if a number is prime.
//● A method to find the greatest common divisor (GCD) of two numbers.
//● A method to find the nth Fibonacci number.
//● Test your methods with various inputs, including edge cases like zero, one, and
//negative numbers.
namespace BridgelabzTraining.senario_based
{
    internal class MathUtils
    {
        static void Main(string[] args)
        {
            try
            {

                // factorial 
                Console.WriteLine(MathUtils.Factorial(5));
                Console.WriteLine(MathUtils.Factorial(0));

                // prime Check
                Console.WriteLine( MathUtils.IsPrime(17));
                Console.WriteLine(MathUtils.IsPrime(1));

                // GCD
                Console.WriteLine( MathUtils.GCD(48, 18));
                Console.WriteLine( MathUtils.GCD(-24, 36));

                // fibonacci
                Console.WriteLine(MathUtils.Fibonacci(10));
                Console.WriteLine(MathUtils.Fibonacci(0));

                // edge case demo
                Console.WriteLine("\nAttempting invalid operations...");
                Console.WriteLine(MathUtils.Factorial(-5));
            }
            catch (ArgumentException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }

            Console.WriteLine("press any key ");
            Console.ReadKey();

        }

        static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact *= i;
            return fact;
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
        public static int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0 && b == 0)
                throw new ArgumentException("GCD is undefined when both numbers are zero.");

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
        public static long Fibonacci(int n)
        {
            if (n < 0)
                throw new ArgumentException("Fibonacci is not defined for negative numbers.");

            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            long prev = 0;
            long current = 1;

            for (int i = 2; i <= n; i++)
            {
                long next = prev + current;
                prev = current;
                current = next;
            }

            return current;
        }

    }
}
