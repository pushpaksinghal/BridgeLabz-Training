using System;

class DoubleOpreation{
    static void Main(String[] args){
        // simple operation on double data type number to understand the principle of BODMAS
        //User input
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        double a = Convert.ToDouble(Console.ReadLine());

        double firstOpeartion = a + (b * c);
        double secondOpreation = (a * b) + c;
        double thirdOpreation = c + (a / b);
        double fourthOpreation  =(a % b) + c;

        Console.WriteLine("The results of Double Operations are "+firstOpeartion+" "+secondOpreation+" "+thirdOpreation+" and "+fourthOpreation );
    }
}