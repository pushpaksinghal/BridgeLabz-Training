using System;

 class ArmstrongOrNot{

    static void Main(String []args){
        //taking input from user of number 
        int number = Convert.ToInt32(Console.ReadLine());
        // take the value of number in n to oprate on
        //and find the result to check if they are same
        int n=number;
        int result=0;
        while(n>0){
            int temp = n%10;
            result = result+(temp*temp*temp);
            n=n/10;
        }
        // print the result
        if(result==number){
            Console.WriteLine("That  is an ArmStrong NUmber");
        }
        else{
            Console.WriteLine("that is not an Armstrong number");
        }
    }
 }