using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_1
{
    internal class TrignometaryFunctionMethod
    {
        static void Main(String[] args)
        {
            double degree = Convert.ToDouble(Console.ReadLine());
            double[] result = Function(degree);
            Console.WriteLine("the value of sin cos and tan  are "+ result[0] +" " + result[1]+" "+result[2]);
        }
        static double[] Function(double degree)
        {
            double[] values = new double[3];
            double radian = (Math.PI / 180) * degree;
            values[0] = Math.Sin(radian);
            values[1] = Math.Cos(radian);
            values[2] = Math.Tan(radian);

            return values;
        }
    }
}
