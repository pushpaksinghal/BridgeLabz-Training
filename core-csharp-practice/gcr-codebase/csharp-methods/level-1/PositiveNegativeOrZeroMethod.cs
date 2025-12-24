using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_1
{
    internal class PositiveNegativeOrZeroMethod
    {
        static void Main(String[] args)
        {
            //taking the input from user
            int number = Convert.ToInt32(Console.ReadLine());
            //printing the value from function
            Console.WriteLine(CheckNumber(number));

        }
        static String CheckNumber(int number)
        {
            //checking whether the number is positive , negative or zero
            if (number > 0)
            {
                return "Positive number";

            }
            else if (number < 0)
            {
                return "Negative number";

            }
            else
            {
                return "zero";
            }
        }

    }

}
