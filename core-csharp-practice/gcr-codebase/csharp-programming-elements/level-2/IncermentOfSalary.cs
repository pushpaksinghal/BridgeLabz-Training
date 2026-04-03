using System;

class IncermentOfSalary{
    static void Main(String[] args){
         //User input
        double salary = Convert.ToDouble(Console.ReadLine());
        double bouns = Convert.ToDouble(Console.ReadLine());
        //finding the bonus amount 
        double addedBonus = (salary*bouns)/100;;
        //addeing it to salary 
        double newSalary = salary+addedBonus;

        Console.WriteLine("The salary is INR"+salary+" and bonus is INR "+bouns+" Hence Total Income is INR "+newSalary);
    }
}