using System;

class TravelComputation {
   static void Main(string[] args) {
    // caculating the distance and time taken from one place to second via third place
      string name = Console.ReadLine();
      string fromCity = Console.ReadLine(), viaCity = Console.ReadLine(), toCity = Console.ReadLine();

      double distanceFromToVia = Convert.ToDouble(Console.ReadLine());
      int timeFromToVia = 4 * 60 + Convert.ToInt32(Console.ReadLine());
      double distanceViaToFinalCity = Convert.ToDouble(Console.ReadLine());
      int timeViaToFinalCity = 4 * 60 + Convert.ToInt32(Console.ReadLine()); 

      double totalDistance = distanceFromToVia + distanceViaToFinalCity;
      int totalTime = timeFromToVia + timeViaToFinalCity;

      // Print the travel details
      Console.WriteLine("The Total Distance travelled by "+name+" from "+fromCity+" to "+toCity+" via "+viaCity+" is "+totalDistance+" km and the Total Time taken is "+totalTime+"minutes");
   }
}
