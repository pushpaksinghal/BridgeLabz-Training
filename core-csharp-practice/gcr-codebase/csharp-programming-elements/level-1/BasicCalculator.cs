using System;

class BasicCalculator{
    static void Main(String[] args){
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        int add = a+b;
        int sub = a-b;
        int multiply = a*b;
        float divide= a/b;

        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers"+a+"and"+b+"is "+add+" "+sub+" "+multiply+" and "+divide); 
    }
}