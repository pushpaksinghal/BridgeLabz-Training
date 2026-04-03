using System;

class SumUntillZeroOrNegative{
    static void Main(String[] args){
        //inside while loop keep taking input untill zero or negative
        double total  = 0;
        while(total>=0){
            double num = Convert.ToDouble(Console.ReadLine());
            if(!(num<=0)){
                total+=num;
            }
            else{
                break;
            }
        }   
        // print the sum of all tehnumber untill zero or neagtive

        Console.WriteLine("total is "+total);
    }
}