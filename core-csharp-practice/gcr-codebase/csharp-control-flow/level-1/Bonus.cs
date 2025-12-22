using System;

class Bonus{
    static void Main(String[]args){
//input the salary and the no of year worked in the company

        double salary = Convert.ToDouble(Console.ReadLine());
        double yearOfServies = Convert.ToDouble(Console.ReadLine());
        double bonusAmount = 0;
        //if thay have worked more then 5 year then they will get 5% bonus
        if(yearOfServies>5){
            bonusAmount = salary*0.05;
        }
        // add the bonus to the current salalry and print the new salary
        Console.WriteLine("the updated salary is "+(salary+bonusAmount));
    }
}