using System;

class AllMultiples {
    static void Main(String[] args) {
        //taking inputfrom the user
        int number = Convert.ToInt32(Console.ReadLine());
        // finding out all the multiples of a number nelow 100 and listing them
        for (int i = 100; i >= 1; i--) {
            if (i % number == 0) {
                Console.WriteLine(i);
            }
        }
    }
}
