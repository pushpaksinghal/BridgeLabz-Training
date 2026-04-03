using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.CsharpArrays.level_2
{
    internal class largesetDigitOfANumber
    {
        static void Main(String[] args)
        {
            //taking user input as string
            String num = Console.ReadLine();
            int lenghtNum = num.Length;
            //coverting intointeger
            int number = Convert.ToInt32(num);
            int[] digits = new int[lenghtNum];

            //Same question as before without array size incerment
            for (int i = 0; i < lenghtNum; i++)
            {
                digits[i] = number % 10;
                number = number / 10;

            }
            int largestDigit = digits[0];
            int secondLargest = digits[0];
            for (int i = 1; i < lenghtNum; i++)
            {
                if (digits[i] > largestDigit)
                {
                    secondLargest = largestDigit;
                    largestDigit = digits[i];

                }
                else if (digits[i] > secondLargest && digits[i] != largestDigit)
                {
                    secondLargest = digits[i];
                }
            }
            Console.WriteLine("largest digit is" + largestDigit + "an the second largest is " + secondLargest);

        }

    }

}
