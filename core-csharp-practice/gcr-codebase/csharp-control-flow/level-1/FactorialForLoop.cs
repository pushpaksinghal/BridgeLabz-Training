using System;

class FactorialForLoop{
    static void Main(String[]args){
        //same code but with for loop
        int number = Convert.ToInt32(Console.ReadLine());
        int n = number;
        int factorial =1;
        for(;n>0;--n){
            factorial*=n;
        }
        Console.WriteLine(factorial);
    }
}