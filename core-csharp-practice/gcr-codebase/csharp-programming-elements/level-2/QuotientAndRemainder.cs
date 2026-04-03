using System;

class QuotientAndRemainder{
    static void Main(String[] args){
        // gien two number finding the quotient and the remainder 
        double first = Convert.ToDouble(Console.ReadLine());
        double second = Convert.ToDouble(Console.ReadLine());
        // using the divide symbol
        double quotient = first/second;
        // using the modulas symbol
        double remainder = first%second;

        Console.WriteLine("the quotient is "+quotient+"and the remainder is "+remainder+"of teh two numbers");
    }
}