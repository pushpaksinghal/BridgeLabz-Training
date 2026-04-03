using System;

class CanYouVote{
    static void Main(String[] args){
        // this show if a person can vote
        //take input of the user age
        int age = Convert.ToInt32(Console.ReadLine());
        //use if  and else statement to deternime if the user is over 18
        if(age>=18){
            Console.WriteLine("This person age is "+age+"and can vote");
        }
        else{
            Console.WriteLine("This person age is "+age+"and cannot vote");
        }
    }
}