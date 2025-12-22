using System;

class SumOfnumberCompareForLoop{
    static void Main(String[]args){
        // same code but with for loop
        int natural = Convert.ToInt32(Console.ReadLine());
        int totalWhile = 0;
        int totalFormula =0;
        
        if(natural>0){
            for(int n=natural;n>0;n--){
                totalWhile+=n;
            }
            totalFormula = (natural*(natural+1))/2;

            if(totalWhile==totalFormula){
                Console.WriteLine("both methods are right"+totalFormula+" and "+totalWhile);
            }
        }
        else{
            Console.WriteLine("not a natural number");
        }

        
    }
}