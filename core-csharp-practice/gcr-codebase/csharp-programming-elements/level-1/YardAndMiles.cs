using System;

class YardAndMiles{
    static void Main(String[] args){
        double feet = Convert.ToDouble(Console.ReadLine());
        double yard = feet*0.333f;
        double miles = feet/0.000189394f;

        Console.WriteLine("the distance in yards is "+yard+"and in miles is "+miles);
    }
}