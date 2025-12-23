using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.CsharpArrays.level_2
{
    internal class FrequancyArray
    {
        static void Main(String[] args)
        {
            //taking input from the user
            String s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            //create two arrays one for storing digits and other for storing frequency
            int[] arr = new int[s.Length];
            int[] freq = new int[s.Length];
            int temp = n;
            for(int i = 0; i < s.Length; i++)
            {
                //storing each digit in the array
                arr[i] = temp % 10;
                freq[i] = -1;
                temp = temp / 10;
            }
            //calculating frequency
            for (int i = 0; i < s.Length; i++)
            {
                int count = 1;
                for(int j = i + 1; j < s.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        //if digit is found increment the count andmark the freqency array ta that index as 0
                        count++;
                        freq[j] = 0;
                    }
                }
                if(freq[i] != 0)
                {
                    freq[i] = count;
                }
            }
            //printing frequency
            for (int i = 0; i < s.Length; i++)
            {
                if(freq[i] != 0)
                {
                    Console.WriteLine("Frequency of " + arr[i] + " is: " + freq[i]);
                }
            }


        }
    }
}
