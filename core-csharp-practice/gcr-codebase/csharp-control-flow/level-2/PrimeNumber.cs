using System;

class PrimeNumber {
    static void Main(String[] args) {
        //taking the input
        int number = Convert.ToInt32(Console.ReadLine());
        bool primeOrNot = true;
        //one is not prime
        if (number <= 1) {
            primeOrNot = false;
        } 
        //ifnot  prime change the bool value
        else {
            for (int i = 2; i < number; i++) {
                if (number % i == 0) {
                    primeOrNot = false;
                    break;
                }
            }
        }

        if (primeOrNot) {
            Console.WriteLine("the number is prime");
        } else {
            Console.WriteLine("the number is not prime");
        }
    }
}
