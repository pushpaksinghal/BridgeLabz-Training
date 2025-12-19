using System;

class TemperatureConversion {
    static void Main(String[] args){
        //basic celcius to fahrenhiet conversion
        double celcius = Convert.ToDouble(Console.ReadLine());
        double fahrenhiet = (celcius*(9/5))+32;

        Console.WriteLine("the "+celcius+" celcius is "+fahrenhiet+"in fahrenhiet");
    }
}