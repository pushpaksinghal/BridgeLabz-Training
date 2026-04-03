using System;

class DivisibleByFive{
    static void Main(String[]args){
        //take the input from user of teh number to check if it is divisible by five
        int value = Convert.ToInt32(Console.ReadLine());
        //use if statement to check if vallue is divisible by five
        if(value%5==0){
            Console.WriteLine(value+" is divisible by 5");
        }
        //use else to say that the valueis not divisible by five
        else{
             Console.WriteLine(value+" is not divisible by 5");

        }
    }
}