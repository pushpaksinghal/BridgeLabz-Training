using System;

class YardAndMiles{
    static void Main(String[] args){
        //converting feet into yards and miles
        //taking input from user
        double feet = Convert.ToDouble(Console.ReadLine());
        double yard = feet*0.333f;
        double miles = feet/0.000189394f;

        Console.WriteLine("the distance in yards is "+yard+"and in miles is "+miles);
    }
}