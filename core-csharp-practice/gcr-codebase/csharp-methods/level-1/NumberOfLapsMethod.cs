using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_1
{
    internal class NumberOfLapsMethod
    {
        static void Main(String[] args)
        {
            //taking the input from user
            int sideA = Convert.ToInt32(Console.ReadLine());
            int sideB = Convert.ToInt32(Console.ReadLine());
            int sideC = Convert.ToInt32(Console.ReadLine());
            //printing teh value from function
            Console.WriteLine("total laps run in a triangle parrk by athelete are " + TotalLaps(sideA, sideB, sideC));

        }
        static int TotalLaps(int sideA, int sideB, int SideC)
        {
            //taking the value from the main and calculating the no of laps
            int perimeter = sideA + sideB + SideC;
            int laps = 5000 / perimeter;
            return laps;
        }

    }
}
