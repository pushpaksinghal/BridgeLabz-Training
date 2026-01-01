using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based
{
    internal class CafeteriaMenu
    {
        //static item list for the shop with prices
        static string[] item = { "Dosa", "Maggie", "Aalo paratha", "pav Bhaji", "Chola Bathura", "Samosa", "Aalo kachori", "Momos", "Lasagna", "Fried Rice" };
        static int[] price = { 60, 40, 50, 70, 80, 20, 25, 60, 65, 70 };
        int[] quantity = new int[10];
        static void Main(string[] args)
        {
            CafeteriaMenu obj = new CafeteriaMenu();
            obj.Menu();

        }

        void Menu()
        {
            //menu for the costomer
            while (true)
            {
                Console.WriteLine("Welcome To GLA Cafeteria");
                Console.WriteLine("1. See Menu");
                Console.WriteLine("2. Order");
                Console.WriteLine("3. Recipt");
                Console.WriteLine("4. exit");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //to see all the items in  the menu
                        SeeMenu();
                        break;
                    case 2:
                        // order the items
                        Order();
                        break;
                    case 3:
                        // recipt for the order 
                        Recipt();
                        break;
                    case 4:
                        Console.WriteLine("thanks for comming");
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
            }
        }

        void SeeMenu()
        {
            // for seeing all the item loop
            for(int i = 0; i < item.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + item[i] +" at "+ price[i]+" per plate");
            }
        }

        void Order()
        {
            // enter the item  no in the console
            Console.WriteLine("enter the item no.to add to the order");
            int itemNo = Convert.ToInt32(Console.ReadLine());
            int quantityOfitem = Convert.ToInt32(Console.ReadLine());
            // and quantity
            quantity[itemNo-1] += quantityOfitem;


        }

        void Recipt()
        {
            int total = 0;
            // for loop for quantity array
            for(int i=0;i< item.Length; i++)
            {
                // plus if more then 0
                if(quantity[i] > 0)
                {
                    int cost = quantity[i] * price[i];
                    Console.WriteLine("the item " + item[i] + "for " + quantity[i] + "is " + cost + "rupee");
                    total += cost;
                }
            }
            // give the total amount
            Console.WriteLine("the total price is " + total);
        }
        
        

    }
}
