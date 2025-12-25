using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_3
{
    internal class UniqueOtpMethod
    {
        static void Main(String[] args)
        {
            //generating  tne random otp and chceking if they are unique
            int[] numbers = RandomOtp();
            if (IsUnique(numbers))
            {
                Console.WriteLine("the 10 otp are all differnt");
            }
            else
            {
                Console.WriteLine("the otp are not differnt");
            }

        }
        //method to generate 10 random otp
        static int[] RandomOtp()
        {
            Random r = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = r.Next(100000, 1000000);
            }
            return numbers;
        }
        //  method to check if all otp are unique
        static bool IsUnique(int[] numbers)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
