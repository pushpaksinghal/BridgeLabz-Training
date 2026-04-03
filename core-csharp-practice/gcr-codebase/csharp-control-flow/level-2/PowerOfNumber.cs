using System;

class PowerOfNumber {
    static void Main(String[] args) {
        //taking input from user 
        int number = Convert.ToInt32(Console.ReadLine());
        int power = Convert.ToInt32(Console.ReadLine());

        int result = 1
        //using the base and the exponent to find the answer;

        for (int i = 1; i <= power; i++) {
            result = result * number;
        }

        Console.WriteLine("rresult is " + result);
    }
}
