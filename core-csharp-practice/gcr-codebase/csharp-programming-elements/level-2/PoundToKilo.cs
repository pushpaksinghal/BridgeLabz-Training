using System;

class PoundToKilo{
    static void Main(String[] args){
        //basic pound to kilogram conversion 
        double pound = Convert.ToDouble(Console.ReadLine());
        double kilogram = pound *0.453592f;

        Console.WriteLine(" The weight of the person in pounds is "+pound+" and in Kg is "+kilogram);
    }
}