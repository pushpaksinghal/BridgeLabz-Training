using System;

class IsPositiveOrNot{
    static void Main(String[]args){
        //taking input 
        int integer = Convert.ToInt32(Console.ReadLine());
        //checking if the input is positive or negative or zero
        if(integer>0){
            Console.WriteLine(integer+" is a positive integer");
        }
        else if(integer<0){
            Console.WriteLine(integer+" is a negative integer");
        }
        else{
            Console.WriteLine("it is zero");
        }
    }
}