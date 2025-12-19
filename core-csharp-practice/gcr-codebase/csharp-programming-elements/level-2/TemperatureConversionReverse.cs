using System;

class TemperatureConversionReverse {
    static void Main(String[] args){
        //basic fahrenhiet to celcius conversion
        double fahrenhiet = Convert.ToDouble(Console.ReadLine());
        double  celcius= ((fahrenhiet-32)*5)/9;

        Console.WriteLine("the "+fahrenhiet+" fahrenhiet is "+celcius+"in celcius");
    }
}