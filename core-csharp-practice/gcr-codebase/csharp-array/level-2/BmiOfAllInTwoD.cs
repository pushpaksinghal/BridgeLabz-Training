using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.CsharpArrays.level_2
{
    internal class BmiOfAllInTwoD
    {
        static void Main(String[] args)
        {
            //taking input for n persons weight and height
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] inputArr = new int[n, 3];
            String[] status = new string[n];
            for (int i = 0; i < n; i++)
            {
                //taking weight and height input
                inputArr[i, 0] = Convert.ToInt32(Console.ReadLine());
                inputArr[i, 1] = Convert.ToInt32(Console.ReadLine());
                //calculating bmi and storing in 2D array
                inputArr[i, 2] = inputArr[i, 0] / (inputArr[i, 1] * inputArr[i, 1]);
                //determining status based on bmi
                if (inputArr[i, 2] < 18.5)
                    status[i] = "Underweight";
                else if (inputArr[i, 2] < 25)
                    status[i] = "Normal";
                else if (inputArr[i, 2] < 30)
                    status[i] = "Overweight";
                else
                    status[i] = "Obese";
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("the wieght and height of the person is " + inputArr[i, 0] + inputArr[i, 1] + "the bmi calculated is " + inputArr[i, 2] + "and the status of that person is " + status[i]);
            }


        }
    }
}
