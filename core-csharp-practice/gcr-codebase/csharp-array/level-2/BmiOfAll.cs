using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.CsharpArrays.level_2
{
    internal class BmiOfAll
    {
        static void Main(String[] args)
        {
            //same queestion but bmi is not inthe 2d array
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] inputArr = new int[n, 2];
            int[] bmi = new int[n];
            String[] status = new string[n];
            for (int i = 0; i < n; i++)
            {
                inputArr[i, 0] = Convert.ToInt32(Console.ReadLine());
                inputArr[i, 1] = Convert.ToInt32(Console.ReadLine());

                bmi[i] = inputArr[i, 0] / (inputArr[i, 1] * inputArr[i, 1]);

                if (bmi[i] < 18.5)
                    status[i] = "Underweight";
                else if (bmi[i] < 25)
                    status[i] = "Normal";
                else if (bmi[i] < 30)
                    status[i] = "Overweight";
                else
                    status[i] = "Obese";
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("the wieght and height of the person is " + inputArr[i, 0] + inputArr[i, 1] + "the bmi calculated is " + bmi[i] + "and the status of that person is " + status[i]);
            }


        }
    }
}
