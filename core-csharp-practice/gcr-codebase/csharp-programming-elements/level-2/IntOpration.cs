using System;

class IntOpration{
    static void Main(String[] args){
        // simple operation on int data type number to understand the principle of BODMAS
         //User input
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        int firstOpeartion = a + (b * c);
        int secondOpreation = (a * b) + c;
        int thirdOpreation = c + (a / b);
        int fourthOpreation  =(a % b) + c;

        Console.WriteLine("The results of Int Operations are "+firstOpeartion+" "+secondOpreation+" "+thirdOpreation+" and "+fourthOpreation );
    }
}