using System;

class SideFromPerimeter{
    static void Main(String[] args){
        // given the perimeter we have to find the size of the side ofethe square
        //taking input from user
        double perimeter = Convert.ToDouble(Console.ReadLine());
        double side= perimeter/4.0f;

        Console.WriteLine("The length of the side is "+side);
    }
}