using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Bus_Dirves
{
    internal class Bus
    {
        static Random r = new Random();
        double distance;
        public void Menu()
        {
            //creating the menu method
            while (true)
            {
                Console.WriteLine("WELCOME TO HERA BUS SERVICES");
                Console.WriteLine("1. Do you want to continue wiht the ride?");
                Console.WriteLine("2. Do you care to get off at this stop");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // keep adding to the distance 
                        distance += r.Next(1, 101);
                        break;
                    case 2:
                        //untill the user stops
                        Console.WriteLine("total distance " + distance + " km and the payables for the travels is  " + (distance * 4));
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
                if(choice == 2)
                {
                    break;
                }
            }
            
        }
    }
}
