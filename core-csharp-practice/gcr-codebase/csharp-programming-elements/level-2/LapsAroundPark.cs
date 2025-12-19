using System;

class LapsAroundPark{
    static void Main(String[] args){
        //running around a triangle park 
        //goal is 5 km

        // how many laps he need to make to complete the goal
        double sideOne = Convert.ToDouble(Console.ReadLine());
        double sideTwo = Convert.ToDouble(Console.ReadLine());
        double sideThree = Convert.ToDouble(Console.ReadLine());
        //calculating the perimeter
        double total = sideOne+sideTwo+sideThree;
        //finding the number of laps
        double laps = 5000/total;

        Console.WriteLine("The total number of rounds the athlete will run is"+laps+" to complete 5 km ");
    }
}