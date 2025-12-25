using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_2
{
    internal class LeapYearMethod
    {
        static void Main(String[] args)
        {
            // Console.WriteLine("Enter year to check leap year or not:");
            int year = Convert.ToInt32(Console.ReadLine());
            LeapYearMethod method = new LeapYearMethod();
            Console.WriteLine(method.IsIt(year));
        }

        String IsIt(int year)
        {
            // A year is a leap year if it is divisible by 4 but not by 100,
            if (year >= 1582 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
            {
                return "year is a leap year";
            }
            else
            {
                return "year is not a leap year";
            }
        }
    }
}
