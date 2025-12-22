using System;
 class FirstIsTheSmallest{
    static void Main(String[]args){
        // taking input form the user of three number to check that if the first one is the smallest
        int first = Convert.ToInt32(Console.ReadLine());
        int second = Convert.ToInt32(Console.ReadLine());
        int thrid = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Is the fisrt the Smallest? "+ ((first<second)?((first<thrid)?"Yes":"No"):"No"));
    }
 }