using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_3
{
    internal class CalenderOfMonth
    {
        static void Main(String[] args)
        {
            //taking the input of month andyear
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            // creating the month and date array to refrence
            string[] months = {"January", "February", "March", "April", "May", "June","July", "August", "September", "October", "November", "December"};
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            //check for leap
            if(IsLeapYear(year))
            {
                days[1] = 29;
            }
            Display(month, year, months, days);
        }
        //method to check for leap year
        static bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        //which day does the first come on
        static int GetFirstDay(int month, int year)
        {
            int d = 1;
            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;
            return d0; 
        }

        // // just to get the count of the date in the calender because i was having problem with spacing in display method so if teh count is 1 there will bw more space adn if there is 2 space there will be less space 
        static int Count(int number)
        {
            if (number == 0) return 1;

            int count = 0;
            while (number != 0)
            {
                count++;
                number /= 10;
            }
            return count;
        }
        //dispalying the calender forthat month in that year
        static void Display(int month, int year, String[] months, int[]days)
        {
            Console.WriteLine(" "+months[month - 1] + " " + year);
            Console.WriteLine(" Sun  Mon  Tue  Wed  Thr  Fri  Sat ");

            int numberOfDays = days[month - 1];
            int fisrtDay = GetFirstDay(month, year);

            for(int i = 0; i < fisrtDay; i++)
            {
                Console.Write("     ");
            }

            for(int j = 1; j <= numberOfDays; j++)
            {
                if (Count(j) < 2)
                {
                    Console.Write("  " + j + "  ");
                }
                else
                {
                    Console.Write("  " + j + " ");
                }

                if ((j + fisrtDay) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}
