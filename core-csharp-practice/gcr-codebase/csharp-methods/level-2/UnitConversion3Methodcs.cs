using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_2
{
    internal class UnitConversion3Methodcs
    {
        static void Main(String[] args)
        {
            //  Input from user
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());
            double number3 = Convert.ToDouble(Console.ReadLine());
            double number4 = Convert.ToDouble(Console.ReadLine());
            double number5 = Convert.ToDouble(Console.ReadLine());
            double number6 = Convert.ToDouble(Console.ReadLine());
            UnitConversion3Methodcs method = new UnitConversion3Methodcs();
            Console.WriteLine(method.Farhenheit2Celsius(number1) + " " + method.Farhenheit2Celsius(number1) + " " + method.Celsius2Farhenheit(number2) + " " + method.Pounds2Kilograms(number3) + " " + method.Kilograms2Pounds(number4) + " " + method.Liters2Gallons(number5) + method.Gallons2Liters(number6));
        }
        // Method for Unit Conversion
        double Farhenheit2Celsius(double number1)
        {
            return (number1 - 32) * 5 / 9;
        }
        double Celsius2Farhenheit(double number2)
        {
            return (number2 * 9 / 5) + 32;
        }
        double Pounds2Kilograms(double number3)
        {
            return number3 * 0.453592;
        }
        double Kilograms2Pounds(double number4)
        {
            return number4 * 2.20462;
        }
        double Gallons2Liters(double number5)
        {
            return number5 * 3.78541;
        }
        double Liters2Gallons(double number6)
        {
            return number6 * 0.264172;
        }
    }
}
