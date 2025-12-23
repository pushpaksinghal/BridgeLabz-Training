using System;

class DaysOfWeek {
    static void Main(String[] args) {
        //taking the input of month day and year
        int month = Convert.ToInt32(Console.ReadLine());
        int day = Convert.ToInt32(Console.ReadLine());
        int year = Convert.ToInt32(Console.ReadLine());
        // finding out teh day of the week on that date usin thses fiormulas
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (day + x + (31 * m0) / 12) % 7;

        Console.WriteLine("Day of week is " + d0);
    }
}
