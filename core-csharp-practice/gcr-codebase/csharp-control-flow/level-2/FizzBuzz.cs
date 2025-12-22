using System;

class FizzBuzz {
    static void Main(String[] args) {
        //taking input
        int number = Convert.ToInt32(Console.ReadLine());
        //listing all teh number but if number is diisible by 3 print fizz if number is divisible by 5 print buzz and if both print fizzbuzz
        if (number > 0) {
            for (int i = 1; i <= number; i++) {
                if (i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine("FizzBuzz");
                } else if (i % 3 == 0) {
                    Console.WriteLine("Fizz");
                } else if (i % 5 == 0) {
                    Console.WriteLine("Buzz");
                } else {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
