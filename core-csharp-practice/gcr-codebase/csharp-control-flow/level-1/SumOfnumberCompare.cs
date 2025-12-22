using System;

class SumOfnumberCompare{
    static void Main(String[]args){
        //taking input 
        int natural = Convert.ToInt32(Console.ReadLine());
        int totalWhile = 0;
        int totalFormula =0;
        int n=natural;

        // checking if teh number is natural 
        // if the number is natural then finding hte sum from while loop and the formula  to compare
        if(n>0){
            while(n>0){
                totalWhile+=n;
                n--;
            }
            totalFormula = (natural*(natural+1))/2;

            if(totalWhile==totalFormula){
                Console.WriteLine("both methods are right"+totalFormula+" and "+totalWhile);
            }
        }
        // if the number is not natural print his statrement
        else{
            Console.WriteLine("not a natural number");
        }

        
    }
}