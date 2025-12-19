using System;

class AreaOfTriangle{
    static void Main(String[] args){
        //finding th earea of triangle 
        //taking input from user 
        int baseVal = Convert.ToInt32(Console.ReadLine());
        int hieghtVal = Convert.ToInt32(Console.ReadLine());

        double area = 0.5* baseVal*hieghtVal;

        Console.WriteLine("the area of triangle is "+area);
    }
}