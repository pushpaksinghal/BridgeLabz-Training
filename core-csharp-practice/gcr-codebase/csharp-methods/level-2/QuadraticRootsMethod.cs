using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_2
{
    internal class QuadraticRootsMethod
    {
        static void Main(String[] args)
        {
            // inout the value a, b and c
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            QuadraticRootsMethod method = new QuadraticRootsMethod();
            // calculate delta
            double delta = Math.Pow(b, 2) - 4 * a * c;
            double[] roots = method.Roots(a, b, delta);
            if (roots.Length == 2)
            {
                Console.WriteLine(roots[0] + " and " + roots[1]);
            }
            else if (roots.Length == 1)
            {
                Console.WriteLine("one root " + roots[0]);
            }
            else
            {
                Console.WriteLine("no roots.");
            }
        }

        double[] Roots(double a, double b, double delta)
        {
            // calculate roots based on delta value
            if (delta > 0)
            {
                double root1 = (-b + delta) / (2 * a);
                double root2 = (-b - delta) / (2 * a);
                return new double[] { root1, root2 };
            }
            else if (delta == 0)
            {
                double root1 = -b / (2 * a);
                return new double[] { root1 };
            }
            else
            {
                return new double[0];

            }
        }
    }
}
