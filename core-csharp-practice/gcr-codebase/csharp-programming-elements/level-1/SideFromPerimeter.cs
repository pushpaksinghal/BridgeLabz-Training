using System;

class SideFromPerimeter{
    static void Main(String[] args){
        double perimeter = Convert.ToDouble(Console.ReadLine());
        double side= perimeter/4.0f;

        Console.WriteLine("The length of the side is "+side);
    }
}