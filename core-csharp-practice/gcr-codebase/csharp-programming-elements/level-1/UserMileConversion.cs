using System;

class UserMileConversion{
    static void Main(String[] args){
        //same as before 
        //taking input from user
        double kiloMeter = Convert.ToDouble(Console.ReadLine());
        double miles = kiloMeter*0.621371f;

        Console.WriteLine("the total miles is "+miles+"for the given kilometer"+kiloMeter);
    }
}