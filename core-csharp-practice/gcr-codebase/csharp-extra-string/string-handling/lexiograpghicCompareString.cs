using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.string_handling
{
    internal class lexiograpghicCompareString
    {
        static void Main(string[] args)
        {
            //input teh string
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int i = 0;
            //get to teh letter that is differnt in both the string 
            while (i< a.Length&&i< b.Length&&a[i]==b[i])
            {
                i++;
            }
            // if the length of both the string is equal witht he i then it is the end of the stirng and they are equal
            if (i==a.Length && i==b.Length)
            {
                Console.WriteLine("equal");
            }
            //if teh letter on i is small in string a then it coe before the other 
            else if (i == a.Length || a[i] < b[i])
            {
                Console.WriteLine(a + " comes before " + b);
            }
            // other way around 
            else
            {
                Console.WriteLine(a + " comes after " + b);
            }
        }
    }
}
