using System;

class SumOfNaturalNumber{
    static void Main(String []args){
        //taking input
        int value = Convert.ToInt32(Console.ReadLine());
        //if the number is natural number  we find the sum of all teh number from one to the number 
        if(!(value<0)){
            int sum = (value*(value+1))/2;
            Console.WriteLine("the Sum of "+value+" natural numbers is "+sum);
        }

        // if the number is not the natural number we print an statement 
        else{
            Console.WriteLine("This is not a natural number");
        }
    }
}