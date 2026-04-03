using System;

class VolumeOfEarth{
    static void Main(String[] args){
        // finding out the volume of earth 
        // using mile conversion to find in mile 
        float radius = 63.78f;
        float radiusMiles = 63.78f*0.621371f;
        double volume = (4/3)*3.14f*Math.Pow(radius,3);
        double volumeMiles = (4/3)*3.14f*Math.Pow(radiusMiles,3);
        Console.WriteLine("the volume of earth in cubic kilometer is "+volume+"and cubic miles is"+volumeMiles);
    }
}