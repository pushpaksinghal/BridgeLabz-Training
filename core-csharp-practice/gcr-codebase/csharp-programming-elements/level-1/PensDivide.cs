using System;

class PensDivide{
    static void Main(String [] args){
        int pens = 14;
        int children = 3;
        int eachChild = pens/children;
        int reamin = pens%children;

        Console.WriteLine("The pen per Student is "+eachChild+" and the remaining pens are"+ reamin);
    }
}