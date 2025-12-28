using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.csharp_built_in_function
{
    internal class BasicCalculator
    {
        static void Main(string[] args)
        {
            //taking input
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            string o = Console.ReadLine();
            if (o == "+")
            {
                Console.WriteLine(Add(a, b));
            }
            else if (o == "-")
            {
                Console.WriteLine(Sub(a, b));
            }
            else if (o == "*")
            {
                Console.WriteLine(Mul(a, b));
            }
            else
            {
                Console.WriteLine(Div(a, b));
            }
        }
        //method for each opreations
        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Sub(double a, double b)
        { 
            return a - b;
        }
        static double Mul(double a, double b) 
        {
            return a * b;
        }
        static double Div(double a, double b)
        { 
            return a / b;
        }
    }
}
