using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_2
{
    internal class UnitConversionMethod
    {
        static void Main(String[] args)
        {
            // Input from user
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());
            double number3 = Convert.ToDouble(Console.ReadLine());
            double number4 = Convert.ToDouble(Console.ReadLine());
            UnitConversionMethod method = new UnitConversionMethod();
            Console.WriteLine("Kilo to Mile: " + method.Kilo2Mile(number1) + "Mile to kilo " + method.Mile2Kilo(number2) + "Meter2Feet " + method.Meter2Feet(number3) + " feet to meter" + method.Feet2Meter(number4));
        }
        // Conversion methods

        double Kilo2Mile(double number1)
        {
            return number1 * 0.621371;
        }
        double Mile2Kilo(double number2)
        {
            return number2 * 1.60934;
        }
        double Meter2Feet(double number3)
        {
            return number3 * 3.28084;
        }
        double Feet2Meter(double number4)
        {
            return number4 * 0.3048;
        }
    }
}
