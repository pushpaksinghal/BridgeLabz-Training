using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.CsharpArrays.level_2
{
    internal class YoungAndTallest
    {
        static void Main(String[] args)
        {
            //taking input
            int[] age = new int[3];
            int[] height = new int[33];
            for (int i = 0; i < 3; i++)
            {
                age[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                height[i] = Convert.ToInt32(Console.ReadLine());
            }


            //finding out the youngest and tallest
            int youngestAge = Math.Min(age[0], Math.Min(age[1], age[2]));


            double tallestHight = Math.Max(height[0], Math.Max(height[1], height[2]));

            Console.WriteLine("youngest age is " + youngestAge);
            Console.WriteLine("Tellest height is " + tallestHight);
        }
    }
}
