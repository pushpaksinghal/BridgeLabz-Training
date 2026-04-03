using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_3
{
    internal class TeamAnalyzeMethod
    {
        static void Main(String[] args)
        {
            // create an object of the class to call non-static methods
            TeamAnalyzeMethod method = new TeamAnalyzeMethod();
            int[] heights = new int[11];
            for (int i = 0; i < 11; i++)
            {
                heights[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] result = method.MeanMinMaxSum(heights);
            // print the result
            Console.WriteLine("mean " + result[0] + " min: " + result[1] + " max: " + result[2] + " sum: " + result[3]);
        }
        int[] MeanMinMaxSum(int[] heights)
        {
            // calculate average, min and max
            int sum = 0;
            int min = heights[0];
            int max = heights[0];
            for (int i = 0; i < heights.Length; i++)
            {
                sum += heights[i];
                min = Math.Min(min, heights[i]);
                max = Math.Max(max, heights[i]);
            }

            int mean = sum / heights.Length;
            //return average, min and max in an array
            return new int[] { mean, min, max, sum };
        }
    }
}
