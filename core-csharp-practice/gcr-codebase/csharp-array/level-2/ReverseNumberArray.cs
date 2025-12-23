using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.CsharpArrays.level_2
{
    internal class ReverseNumberArray
    {
        static void Main(String[] args)
        {
            //taking input from the user
            String s = Console.ReadLine();
            //converting the string to integer
            int number = Convert.ToInt32(s);
            int temp = number;
            int[] arr = new int[s.Length];
            int i = 0;
            //reversing the number and storing each digit in the array
            while (temp > 0)
            {
                int digit = temp % 10;
                arr[i] = digit;
                i++;
                temp /= 10;
            }

            for (int j = 0; j < i; j++)
            {
                Console.Write(arr[j]);
            }
        }
    }
}
