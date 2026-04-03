using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_2
{
    internal class BmiMethodCalculator
    {
        static void Main(String[] args)
        {
            // Input number of persons
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] presonData = new Double[n, 3];
            String[] status = new string[n];
            BmiMethodCalculator method = new BmiMethodCalculator();
            // Input weight and height for each person
            for (int i = 0; i < n; i++)
            {
                presonData[i, 0] = Convert.ToDouble(Console.ReadLine());
                presonData[i, 1] = Convert.ToDouble(Console.ReadLine());
                presonData[i, 2] = method.Bmi(presonData[i, 0], presonData[i, 1]);
                status[i] = method.BmiStatus(presonData[i, 2]);
            }
            // Output weight, height, BMI and status for each person
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Weight: " + presonData[i, 0] + " Height: " + presonData[i, 1] + " BMI: " + presonData[i, 2] + " Status: " + status[i]);
            }

        }
        double Bmi(double weight, double height)
        {
            // calculate thebmi
            return weight / (height * height);
        }
        String BmiStatus(double bmi)
        {
            // determine the bmi status
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                return "Normal weight";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obesity";
            }
        }
    }
}
