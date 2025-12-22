using System;

class LeapYearSingleIf {
    static void Main(String[] args) {
        //sAME but wiht one if
        int year = Convert.ToInt32(Console.ReadLine());

        if (year >= 1582 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))) {
            Console.WriteLine("year is a leap year");
        } else {
            Console.WriteLine("year is not a leap year");
        }
    }
}
