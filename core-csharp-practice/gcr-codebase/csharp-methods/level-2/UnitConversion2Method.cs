using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_2
{
    internal class UnitConversion2Method
    {
        static void Main(String[] args)
        {
            // Input from user
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());
            double number3 = Convert.ToDouble(Console.ReadLine());
            double number4 = Convert.ToDouble(Console.ReadLine());
            UnitConversion2Method method = new UnitConversion2Method();
            Console.WriteLine("meter to inche " + method.Meter2Inche(number1) + "inche to meter " + method.Inche2Meter(number2) + "inche to cm" + method.Inche2Cm(number2) + "Yard2Feet " + method.Yard2Feet(number3) + " feet to Yard" + method.Feet2Yard(number4));
        }

        // Conversion methods
        double Meter2Inche(double number1)
        {
            return number1 * 39.3701;
        }
        double Inche2Meter(double number2)
        {
            return number2 * 0.0254;
        }
        double Inche2Cm(double number2)
        {
            return number2 * 2.54;
        }
        double Yard2Feet(double number3)
        {
            return number3 * 3;
        }
        double Feet2Yard(double number4)
        {
            return number4 * 0.333333;
        }
    }
}
