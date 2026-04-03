using System;

class BmiCalculator {
    static void Main(String[] args) {
        // input weight and hight
        double weight = Convert.ToDouble(Console.ReadLine());
        double heightCm = Convert.ToDouble(Console.ReadLine());
        // using the standard formula calculating the Bmi
        double height = heightCm / 100;
        double bmi = weight / (height * height);

        Console.WriteLine("BMI is " + bmi);
        // catagorizeing the output
        if (bmi < 18.5) {
            Console.WriteLine("underweight");
        } else if (bmi < 25) {
            Console.WriteLine("normal weight");
        } else if (bmi < 30) {
            Console.WriteLine("overweight");
        } else {
            Console.WriteLine("obese");
        }
    }
}
