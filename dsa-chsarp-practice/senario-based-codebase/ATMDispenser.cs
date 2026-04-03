using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based
{
    internal class ATMDispenser
    {
        public Dictionary<int ,int> Input(int n)
        {
            Dictionary<int,int> typeNote= new Dictionary<int,int>();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("enter the type of note and the number of that type of note");
                int note = Convert.ToInt32(Console.ReadLine());
                int count = Convert.ToInt32(Console.ReadLine());
                typeNote.Add(note, count);
            }
            return typeNote;
        }
        // this will work for both senario one and two besause the number  of type of npte is user dependent
        public void minimumNotes(int amount, int n)
        {
            int initailamount = amount;
            Dictionary<int, int> dic = Input(n);
            Dictionary<int , int>result = new Dictionary<int , int>();
            foreach(KeyValuePair<int, int> item in dic)
            {
                int noteValue = item.Key;
                int count = item.Value;

                if (amount >= noteValue)
                {
                    int needed = amount / noteValue;
                    int notesUsed = Math.Min(needed, count);

                    if (notesUsed > 0)
                    {
                        result.Add(noteValue, notesUsed);
                        amount -= notesUsed * noteValue;
                    }
                }
            }
            //thrid senario for fallback combo
            if (amount != 0)
            {
                Console.WriteLine(initailamount - amount + "rupees is the fallback combo because the exact change is not possible");
                foreach (var item in result)
                {
                    Console.WriteLine("Note" + item.Key + " : " + item.Value);
                }
            }
            else
            {

                Console.WriteLine(" It can be done with these number of notes.");
                foreach (var item in result)
                {
                    Console.WriteLine("Note"+item.Key+" : "+item.Value);
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Enter the amount and the number of type of note ypu need");
            int amount = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            minimumNotes(amount, n);
        }

        public static void Main(string[] args)
        {
            ATMDispenser atm = new ATMDispenser();
            atm.Display();
        }
    }

    
}
