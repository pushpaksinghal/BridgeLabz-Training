using System;

class AbundantNumber {
    static void Main(String[] args) {
        //taking input 
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        //abundant number are those whose digitsum is more then there value
        for (int i=1; i<number;i++) {
            if (number%i==0) {
                sum = sum+i;
            }
        }
        //if the number is abundant then print this  otherwise print that

        if (sum >number) {
            Console.WriteLine("abundant Number");
        } else {
            Console.WriteLine("not an abundant Number");
        }
    }
}
