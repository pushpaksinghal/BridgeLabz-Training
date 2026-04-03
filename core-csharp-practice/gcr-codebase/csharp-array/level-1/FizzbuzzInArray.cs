using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.CsharpArrays.level1
{
    internal class FizzbuzzInArray
    {
        static void Main(String[] args)
        {
            //taking input from the user
            int n = Convert.ToInt32(Console.ReadLine());
            int[] fizzbuzz = new int[n];
            for(int i = 0; i < n; i++)
            {
                //checking the conditions for fizzbuzz
                if (i%3==0&& i % 5 == 0)
                {
                    fizzbuzz[i] = -1;
                }
                else if (i % 3 == 0)
                {
                    fizzbuzz[i] = -2;
                }
                else if (i % 5 == 0)
                {
                    fizzbuzz[i] = -3;
                }
                else
                {
                    fizzbuzz[i] = i;
                }
            }
            for(int i = 0; i < n; i++)
            {
                //printing the fizzbuzz array
                if (fizzbuzz[i]==-1)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (fizzbuzz[i] == -2)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fizzbuzz[i] == -3)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(fizzbuzz[i]);
                }
            }
        }

    }
}
