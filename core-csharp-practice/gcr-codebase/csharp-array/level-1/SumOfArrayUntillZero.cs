using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.CsharpArrays.level1
{
    internal class SumOfArrayUntillZero
    {
        static void Main(String[] args)
        {
            //create a while loop
            int i = 0;
            int sum = 0;

            int[] numbers = new int[10];
            while (numbers.Length > 0)
            {
                //taking input
                int temp = Convert.ToInt32(Console.ReadLine());
                if (temp > 0)
                {
                    //keep taking input untill zero
                    numbers[i] = temp;
                    sum += numbers[i];
                    i++;
                }
                else
                {
                    break;
                }
            }
            //print all the number
            for (int n = 0; n <= i; n++)
            {
                Console.WriteLine(numbers[n]);
            }
            //print the sum
            Console.WriteLine(sum);

        }
    }
}
