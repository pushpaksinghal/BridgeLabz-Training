using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.CsharpArrays.level_2
{
    internal class LargestSecondLargest
    {
        static void Main()
        {
            //taking input from the user
            int number = Convert.ToInt32(Console.ReadLine());

            int maxDigit = 10;
            int[] digits = new int[maxDigit];
            int index = 0;
            //storing each digit in the array
            while (number > 0)
            {
                if (index == maxDigit)
                {
                    //increase the size of the array by 10
                    maxDigit += 10;
                    int[] temp = new int[maxDigit];
                    //copy the elements to the temp array
                    for (int i = 0; i < digits.Length; i++)
                    {
                        temp[i] = digits[i];
                    }
                    //make the digits array equal to the temp array
                    digits = temp;
                }
                //extract the last digit
                digits[index] = number % 10;
                index++;
                number /= 10;
            }

            int largest = 0;
            int secondLargest = 0;
            //finding the largest and second largest digit
            for (int i = 0; i < index; i++)
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

            Console.WriteLine("largest digit is" + largest + "an the second largest is " + secondLargest);

        }
    }
}
