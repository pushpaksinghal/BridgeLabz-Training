using System;

class PensDivide{
    static void Main(String [] args){
        //dividing the pens into student and finding out the remianing pens
        int pens = 14;
        int children = 3;
        int eachChild = pens/children;
        int reamin = pens%children;

        Console.WriteLine("The pen per Student is "+eachChild+" and the remaining pens are"+ reamin);
    }
}