using System;

class SwapTwoNumber{
    static void Main(String[] args){
        //swapping two number 
        // //User input
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        //added the number and stored in a 
        a= a+b;
        //subtracted the b from the sum stored in a 
        b=a-b;
        //subtracting the new b from the sum
        a=a-b;

        Console.WriteLine("the swapped numbers are "+a+" "+b);
    }
}