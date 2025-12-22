using System;

class FactorOfNumber {
    static void Main(String[] args) {
        //taking input
        int number = Convert.ToInt32(Console.ReadLine());
        //listing all teh factor of a number 
        for (int i = 1; i < number; i++) {
            if (number % i == 0) {
                Console.WriteLine(i);
            }
        }
    }
}
