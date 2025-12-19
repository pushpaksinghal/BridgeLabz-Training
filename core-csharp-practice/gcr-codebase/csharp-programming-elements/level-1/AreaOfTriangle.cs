using System;

class AreaOfTriangle{
    static void Main(String[] args){
        int baseVal = Convert.ToInt32(Console.ReadLine());
        int hieghtVal = Convert.ToInt32(Console.ReadLine());

        double area = 0.5* baseVal*hieghtVal;

        Console.WriteLine("the area of triangle is "+area);
    }
}