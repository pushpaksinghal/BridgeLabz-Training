using System;

class HarshadNumber {
    static void Main(String[] args) {
        int number = Convert.ToInt32(Console.ReadLine());
        int temp = number;
        int sum = 0;

        // calculate sum of digits
        while (temp!= 0) {
            sum = sum+(temp%10);
            temp = temp/10;
        }
        //if the number is divisible by it digit sum then it is a harshad number otherwise it is not
        if (number%sum == 0) {
            Console.WriteLine("Harshad Number");
        } else {
            Console.WriteLine("Not a Harshad Number");
        }
    }
}
