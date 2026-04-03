using System;

class TotalPossiblehandShake{
    static void Main(String[] args){
        // given no. of student 
        // using the formula (n*(n-1))/2 we can find number of connection between the student 
        //taking input from user
        int numberOfStudent = Convert.ToInt32(Console.ReadLine());
        int total  = (numberOfStudent*(numberOfStudent-1))/2;

        Console.WriteLine(total);
    }
}