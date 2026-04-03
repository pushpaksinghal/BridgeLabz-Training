using System;

class InterestSimple {
    static void Main(String[] args) {
        //take input from user
        double principle = Convert.ToDouble(Console.ReadLine());
        double rate = Convert.ToDouble(Console.ReadLine());
        double time = Convert.ToDouble(Console.ReadLine());
        double simpleInterest = (principle * rate * time) / 100;//cal simple interset
        Console.WriteLine(simpleInterest);

    }
}