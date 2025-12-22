using System;

class WhichIsLarger{
    static void Main(String[] args){
        // taking input 

        int fisrt = Convert.ToInt32(Console.ReadLine());
        int second = Convert.ToInt32(Console.ReadLine());
        int third = Convert.ToInt32(Console.ReadLine());
        // checking which is teh largest

        if((fisrt>second)&& (fisrt>third)){ Console.WriteLine("Is the first number the largest? YES \nIs the second number the largest? NO \nIs the third number the largest? NO");}
        else if((second>fisrt)&&(second>third)){ Console.WriteLine("Is the first number the largest? NO \nIs the second number the largest? YES \nIs the third number the largest? NO");}
        else{ Console.WriteLine("Is the first number the largest? NO \nIs the second number the largest? NO \nIs the third number the largest? YES");}
    }
}