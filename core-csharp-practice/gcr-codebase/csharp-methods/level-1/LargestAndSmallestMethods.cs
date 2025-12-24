using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_1
{
    internal class LargestAndSmallestMethods
    {
        static void Main(String[] args)
        {
            //tasking the input fromthe user
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            //taking the output fromt the method
            int[] re = LAndS(number1, number2, number3);
            //printing the result
            Console.WriteLine("the largest number is " + re[0]);
            Console.WriteLine("the smallest number is " + re[1]);
        }
        static int[] LAndS(int number1, int number2, int number3)
        {
            //taking the values from main and returning the array storing largest and smallest number
            int[] result = new int[2];
            result[0] = (number1 > number2) ? (number1 > number3) ? number1 : (number2 > number3) ? number2 : number3 : number2;

            result[1] = (number1 < number2) ? (number1 < number3) ? number1 : (number2 < number3) ? number2 : number3 : number2;

            return result;
        }
    }
}
