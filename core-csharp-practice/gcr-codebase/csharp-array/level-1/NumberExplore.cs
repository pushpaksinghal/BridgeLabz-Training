using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.CsharpArrays.level1
{
    internal class NumberExplore
    {
        static void Main(String[] argsa)
        {
            //make a array
            int[] numArr = new int[5];
            for (int i = 0; i < numArr.Length; i++)
            {
                //take the user input
                numArr[i] = Convert.ToInt32(Console.ReadLine());
                if (numArr[i] > 0)
                {
                    //check the number for even odd if it is more the zero
                    if (numArr[i] % 2 == 0)
                    {
                        Console.WriteLine("the number " + numArr[i] + " is positive even number");
                    }
                    else
                    {
                        Console.WriteLine("the number " + numArr[i] + " is positive odd number");
                    }
                }
                // if teh number is less then zero
                else if (numArr[i] < 0)
                {
                    Console.WriteLine("the number " + numArr[i] + "is a negative number");
                }
                //if the number is zero
                else
                {
                    Console.WriteLine("the number " + numArr[i] + "is Zero");
                }
            }
            if (numArr[0] == numArr[numArr.Length - 1])
            {
                Console.WriteLine("both the number are equal");
            }
            else if (numArr[0] > numArr[numArr.Length - 1])
            {
                Console.WriteLine(numArr[0] + "is greater");
            }
            else
            {
                Console.WriteLine(numArr[numArr.Length - 1] + "is greater");
            }
        }
    }
}
