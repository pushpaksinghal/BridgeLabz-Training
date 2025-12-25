using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_2
{
    internal class AverageOfRandommthod
    {
        static void Main(String[] args)
        {
            // create an object of the class to call non-static methods
            AverageOfRandommthod method = new AverageOfRandommthod();
            int[] RandomNumber = method.GetRandom();
            int[] result = method.AverageMinMax(RandomNumber);
            // print the result
            Console.WriteLine("arverage " + result[0] + " min: " + result[1] + " max: " + result[2]);
        }

        int[] GetRandom()
        {
            // generate 5 random numbers between 1000 and 9999
            int[] RandomNumber = new int[5];
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                //store random number in array
                RandomNumber[i] = r.Next(1000, 10000);
            }
            return RandomNumber;
        }

        int[] AverageMinMax(int[] RandomNumber)
        {
            // calculate average, min and max
            int sum = 0;
            int min = RandomNumber[0];
            int max = RandomNumber[0];
            for (int i = 0; i < RandomNumber.Length; i++)
            {
                sum += RandomNumber[i];
                min = Math.Min(min, RandomNumber[i]);
                max = Math.Max(max, RandomNumber[i]);
            }

            int average = sum / RandomNumber.Length;
            //return average, min and max in an array
            return new int[] { average, min, max };
        }

    }


}
