using System;

class TotalPossiblehandShake{
    static void Main(String[] args){
        int numberOfStudent = Convert.ToInt32(Console.ReadLine());
        int total  = (numberOfStudent*(numberOfStudent-1))/2;

        Console.WriteLine(total);
    }
}