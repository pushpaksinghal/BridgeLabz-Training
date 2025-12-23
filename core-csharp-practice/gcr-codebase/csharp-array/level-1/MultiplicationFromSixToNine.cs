using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.CsharpArrays.level1
{
    internal class MultiplicationFromSixToNine
    {
        static void Main(String[] args)
        {
            //taking input from the user
            int number = Convert.ToInt32(Console.ReadLine());
            int[] multiArr = new int[4];
            //calculate table of the number from 6 to 9
            for (int i = 0; i < multiArr.Length; i++)
            {
                multiArr[i] = (i + 6) * number;
                Console.WriteLine((i + 6) + " * " + number + " = " + multiArr[i]);
            }
        }
    }
}
