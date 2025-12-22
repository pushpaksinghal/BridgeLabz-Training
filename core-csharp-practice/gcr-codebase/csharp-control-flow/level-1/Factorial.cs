using System;

class Factorial{
    static void Main(String[]args){
        //a factorial is a multiplicative itration of the given number till one
        int number = Convert.ToInt32(Console.ReadLine());
        int n = number;
        int factorial =1;
        //use while loop to itrate from the number to one
        while(n>0){
            factorial*=n;
            --n;
        }
        //print the ans
        Console.WriteLine(factorial);
    }
}