using System;

class LeapYear {
    static void Main(String[] args) {
        // input the year
        int year = Convert.ToInt32(Console.ReadLine());

        // check for  calendar
        if (year >= 1582) {
            if (year % 400 == 0) {
                Console.WriteLine("year is a leap year");
            } else if (year % 100 == 0) {
                Console.WriteLine("year is not a leap year");
            } else if (year % 4 == 0) {
                Console.WriteLine("year is a leap year");
            } else {
                Console.WriteLine("year is not a leap year");
            }
        } 
        // not a leap year
        else {
            Console.WriteLine("leap year works only for year >= 1582");
        }
    }
}
