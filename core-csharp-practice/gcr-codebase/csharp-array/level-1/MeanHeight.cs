using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.CsharpArrays.level1
{
    internal class MeanHeight
    {
        static void Main(String[] args)
        {
            //taking height of 11 people as input
            int[] height = new int[11];
            int sum = 0;
            int mean = 0;
            //stroing height in array and calculate sum
            for (int i = 0; i < 11; i++)
            {
                height[i] = Convert.ToInt32(Console.ReadLine());
                sum += height[i];
            }
            mean = sum / 11;

            Console.WriteLine("mean height is: " + mean);
        }
    }
}
