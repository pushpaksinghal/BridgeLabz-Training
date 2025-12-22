using System;

class SumUntillZero{

    static void Main(String[]args){
        //taking input one time
        double total = 0.0;
        double number = Convert.ToDouble(Console.ReadLine());
        // is the input is not zero keep taking input 
        while(number!=0){
            total+=number;
            double num =Convert.ToDouble(Console.ReadLine());
            number = num; 
        }
        // print the sum of all teh input untill zero
        Console.WriteLine("the total is "+total);
    }
}