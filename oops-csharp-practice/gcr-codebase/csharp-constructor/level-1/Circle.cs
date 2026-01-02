using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_constructor_accessmodifiers.level_1
{
    internal class Circle
    {
        // created the radius atribute
        double radius;
        // parameter con
        public Circle(double radius)
        {
            this.radius = radius;
        }
        // con chaining
        public Circle() : this(1.0)
        {
            Console.WriteLine("this is a default circle area");
        }
        // finding the area off circle
        public void area()
        {
            double area = 3.14 * radius * radius;
            Console.WriteLine("the area is " + area);


        }
    }

    class Display()
    {
        //calling the class in main
        static void Main(string[] args)
        {
            Circle r1 = new Circle();
            r1.area();

            Circle r2 = new Circle(13.22);
            r2.area();
        }
    }
}
