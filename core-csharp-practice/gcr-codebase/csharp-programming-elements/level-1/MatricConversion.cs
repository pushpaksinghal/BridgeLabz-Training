using System;

class MatricConversion{
    static void Main(String[] args){
        double centimeter = Convert.ToDouble(Console.ReadLine());
        double inFeet = centimeter*0.0328084f;
        double inInches = centimeter*0.393701f;

        Console.WriteLine("your hieght in cm is"+centimeter+"while in feet is "+inFeet+"and inches is "+inInches);
    }
}