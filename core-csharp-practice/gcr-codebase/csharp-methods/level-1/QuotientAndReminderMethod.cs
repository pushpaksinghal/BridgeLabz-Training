using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_1
{
    internal class QuotientAndReminderMethod
    {
        static void Main(String[] args)
        {
            //taking the input from user
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            //taking the output from the method
            int[] re = QAndR(number1, number2);
            //printing the result
            Console.WriteLine("the quqtient and reminder are " + re[0] + " and " + re[1]);
        }

        static int[] QAndR(int number1, int number2)
        {
            //taking the values from main and returning the array storing quotient and reminder
            int[] result = new int[2];
            result[0] = number1 / number2;
            result[1] = number1 % number2;
            return result;
        }
    }
}
