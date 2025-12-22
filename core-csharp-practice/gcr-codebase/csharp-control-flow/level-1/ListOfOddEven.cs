using System;

class ListOfOddEven{
    static void Main(String[]args){
        //taking input
        int number = Convert.ToInt32(Console.ReadLine());
        int n=2;
        //find out in between 1 and the input which number is odd or even
        while(n<number){
            if(n%2==0){
                Console.WriteLine(n+"is even");
            }
            else{
                Console.WriteLine(n+"is Odd");
            }
            ++n;
        }
    }
}