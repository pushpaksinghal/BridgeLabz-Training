using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_1
{
    internal class WindChillMethod
    {
        static void Main(String[] args)
        {
            //taking input fromthe user
            double tempurature = Convert.ToDouble(Console.ReadLine());
            Double windSpped = Convert.ToDouble(Console.ReadLine());
            //printing the valule
            Console.WriteLine("the wind chill is " +WindMethod(tempurature, windSpped));

        }

        static double WindMethod(double tempurature, double windSpeed)
        {
            //calculating the wind speed
            return 35.74 + (0.6215 * tempurature) + (0.4275 * tempurature - 35.75) * (windSpeed * 0.16);
        }
    }
}
