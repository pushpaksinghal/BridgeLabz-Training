using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_objects.Circle
{
    internal class CircleClass
    {
        double radius;

        public CircleClass(double radius)
        {
            this.radius = radius; 
        }

        public double Area(double redius)
        {
            double area = 3.14*redius*radius;
            return area;
        }

        public void Display(double area,double radius)
        {
            Console.WriteLine("The area is " + area);
        }
    }
}
