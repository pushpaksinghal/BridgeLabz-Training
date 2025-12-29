using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based
{
    internal class HourlyTemp
    {
        static void Main(string[] args)
        {
            //cearteing the object of class to access the methods
            HourlyTemp obj = new HourlyTemp();
            // taking teh input of the temp in all the hours
            double[,] temp = obj.InputTemp();
            double[] averageTemp = obj.average(temp);
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(averageTemp[i]);
            }

            Console.WriteLine(obj.HottestDay(averageTemp));
            Console.WriteLine(obj.ColdestDay(averageTemp));

        }

        double[,] InputTemp()
        {
            double[,] hourlytemp = new double[7, 24];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 24; j++)
                {
                    hourlytemp[i, j] = Convert.ToDouble(Console.ReadLine());
                }

            }
            return hourlytemp;
        }

        // takingthe average of all temp in a day 
        double[] average(double[,] hourlytemp)
        {
            double[] averageTemp = new double[7];

            for (int i = 0; i < 7; i++)
            {
                double a = 0;
                for (int j = 0; j < 24; j++)
                {
                    a += hourlytemp[i, j];
                }
                averageTemp[i] = a / 24;
            }
            return averageTemp;
        }
        // finding the hotest day 
        double HottestDay(double[] averageTemp)
        {
            double max = 0;
            for (int i = 0; i < 7; i++)
            {
                if (averageTemp[i] > max)
                {
                    max = averageTemp[i];
                }
            }
            return max;
        }
        // finding the coldest day
        double ColdestDay(double[] averageTemp)
        {
            double min = averageTemp[0];
            for (int i = 0; i < 7; i++)
            {
                if (averageTemp[i] < min)
                {
                    min = averageTemp[i];
                }
            }
            return min;
        }
    }
}
