using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based
{
    internal class Flip_Key_Logical
    {
        public static void Main(String[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. Convert Your String.");
                Console.WriteLine("2. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: CleanseAndInvert(); break;
                    case 2: flag = false; break;
                    default: Console.WriteLine("Invaild choice."); flag = false; break;
                }
            }
        }

        static void CleanseAndInvert()
        {
            Console.WriteLine("Enter  a String. ");
            string input = Console.ReadLine();

            if(input.Length<6 && input.Contains(@"[ \W]"))
            {
                Console.WriteLine("Invalid String Input");
                return;
            }
            else
            {
                int count = 0;
                string temp = "";
                input = input.ToLower();
                for(int i = input.Length - 1; i >= 0; i--)
                {
                    if ((int)input[i] %2 != 0)
                    {
                        if (count % 2 == 0)
                        {
                            temp += input[i].ToString().ToUpper();
                        }
                        else
                        {
                            temp += input[i];
                        }
                        count++;
                    }
                }
                Console.WriteLine("The generated key is - " + temp);
                return;
            }
        }
    }
}
