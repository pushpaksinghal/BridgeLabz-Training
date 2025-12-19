using System;

class DividingAmongChildren{
    static void Main(String [] args){
        //dividing the pens into student and finding out the remianing pens
        int pens = Convert.ToInt32(Console.ReadLine());
        int children = Convert.ToInt32(Console.ReadLine());
        int eachChild = pens/children;
        int reamin = pens%children;

        Console.WriteLine("The Chocolates per child is "+eachChild+" and the remaining chocolates are"+ reamin);
    }
}