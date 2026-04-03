using BridgelabzTraining.senario_based.Office_Management;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based
{
    class PasswordCraker
    {
        static bool isCracked = false;

        static void Crack(int[] attempt, int index, int target,int digits)
        {
            if (isCracked)
                return;

            if (index == digits)
            {
                int guess = 0;
                for (int i=0;i<attempt.Length;i++)
                {
                    guess = guess * 10 + attempt[i];
                }

                if (guess==target)
                {
                    Console.WriteLine("Password cracked: " + guess);
                    isCracked = true;
                }
                return;
            }

            // Try ALL printable ASCII characters
            for (int ch = 0; ch <= 9; ch++)
            {
                attempt[index] = ch;
                Crack(attempt, index + 1, target,digits);
            }
        }

        static void Main()
        {
            Console.Write("Enter password: ");
            int password = Convert.ToInt32(Console.ReadLine());
            int digits = Math.Abs(password).ToString().Length;
            int[] attempt = new int[digits];
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Crack(attempt, 0, password,digits);
            watch.Stop();
            Console.WriteLine("time taken: " + watch.ElapsedTicks+ "ticks");

            if (!isCracked)
                Console.WriteLine("Password not cracked.");
        }
    }

}
