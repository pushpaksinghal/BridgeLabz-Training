using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_3
{
    internal class EuclideanMethod
    {
        static void Main(String[] args)
        {
            //taking the input from the user
            double x1= Convert.ToDouble(Console.ReadLine());
            double y1= Convert.ToDouble(Console.ReadLine());
            double x2= Convert.ToDouble(Console.ReadLine());
            double y2= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("distance between is" + distance(x1, x2, y1, y1));
            Console.WriteLine(Equation(x1, x2, y1, y2));
        }
        //calculating the distance 
        static double distance(double x1,double x2,double y1, double y2)
        {
            return Math.Sqrt(Math.Pow((x2-x1),2)+ Math.Pow((y2 - y1), 2));
        }
        //getting the equation for the points

        static String Equation(double x1, double x2, double y1, double y2)
        {
            double m = (y2 - y1) / (x2 - x1);
            double b = y1 - m * x1;
            return "y = " + m + "x + " + b;
        }
    }
}
