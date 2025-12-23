using System;

class DigitCount {
    static void Main(String  [] args) {
        // inputing the number from the user
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        // counting the no of digit in a number
        while (number != 0) {
            number = number / 10;
            count++;
        }

        Console.WriteLine("number of digits is " + count);
    }
}
