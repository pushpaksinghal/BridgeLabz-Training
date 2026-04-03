using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_1
{
    internal class SpringSeasonMethod
    {
        static void Main(String[] args)
        {
            //taking the user input
            String month = Console.ReadLine();
            int date = Convert.ToInt32(Console.ReadLine());
            //storing the function reuslt in the bool variable
            bool result = IsIt(date, month);
            //printing the result
            if (result == true)
            {
                Console.WriteLine("It is spring Season");
            }
            else
            {
                Console.WriteLine("It is not Spring Season");
            }
        }

        static bool IsIt(int date, String month)
        {
            //checking whether the given date and month is in spring season or not
            if (month == "Macrh")
            {
                if (date >= 20 && date <= 31)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (month == "April" || month == "May")
            {
                return true;
            }
            else if (month == "June")
            {
                if (date >= 1 && date <= 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
    }
}
