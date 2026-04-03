using System;

class SpringSeason {
    static void Main(String[]args){
        String month = Console.ReadLine();
        //taking input of month and date

        int date= Convert.ToInt32(Console.ReadLine());
        // using if and else satement to determine if the user input date fits in the range
        if(month=="March"){
            if(date >= 20 && date<=31 ){
                Console.WriteLine("Its Spring Season");
            }
            else{
                Console.WriteLine("Its not Spring Season");
            }
        }
        else if (month =="June"){
            if(date <= 20 && date<=1 ){
                Console.WriteLine("Its Spring Season");
            }
            else{
                Console.WriteLine("Its not Spring Season");
            }
        }
        else{
            Console.WriteLine("Its not Spring Season");

        }
    }
}