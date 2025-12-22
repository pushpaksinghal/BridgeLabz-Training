using System;

class MultiplicationTable{
    static void Main(String []args){
        //taking input from user

        int number = Convert.ToInt32(Console.ReadLine());
        //driving the table of that number from 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + (number * i));
        }
    }
}