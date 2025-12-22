using System;

class CounterGameFor{
    static void Main(String[]args){
        //same counter but using for loop
        int number = Convert.ToInt32(Console.ReadLine());

        for(int n=number ; n>=1;--n){
            Console.WriteLine(n-1);
        }
    }
}