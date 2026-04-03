using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_3
{
    internal class CollinearMethod
    {
        static void Main(String[] args)
        {
            //input the coordinates of three points
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());

            if(SlopeFor(x1, y1, x2, y2, x3, y3) && TriangleFor(x1, y1, x2, y2, x3, y3))
            {
                Console.WriteLine("the point are collinear");
            }
            else
            {
                Console.WriteLine("the point are not collinear");
            }
        }
        //method to check the slope of three points
        static bool SlopeFor(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double slope1 = (y2 - y1) / (x2 - x1);
            double slope2 = (y3 - y2) / (x3 - x2);
            double slope3 = (y1 - y3) / (x1 - x3);
            return (slope1 == slope2 )? (slope1==slope3):false;
        }
        //method to check area of triangle formed by three points
        static bool TriangleFor(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            if(0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) == 0)
            {
                return true;
            }
            return false;
            
        }
    }
}
