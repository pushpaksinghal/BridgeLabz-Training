using System;

class CounterGame{
    static void Main(String[]args){
        //simple counter that start from the inputed number and ends when reaching 1
        int number = Convert.ToInt32(Console.ReadLine());
        // use while lopp for the itrations
        while(number>=1){
            Console.WriteLine(number-1);
            --number;
        }
    }
}