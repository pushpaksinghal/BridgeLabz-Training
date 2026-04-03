using System;

class GreatestFactor {
    static void Main(String[] args) {
        //taking input
        int number = Convert.ToInt32(Console.ReadLine());
        int greaterstFactor = 1;
        // finding out the gratest factor of a number
        for (int i = number - 1; i >= 1; i--) {
            if (number % i == 0) {
                greaterstFactor = i;
                break;
            }
        }

        Console.WriteLine("Greatest factor is " + greaterstFactor);
    }
}
