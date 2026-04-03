using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Trrafic_Manager
{
    internal class TrafficMenu
    {
        ITraffic traffic = new TrafficUtility();

        public void StartTraffic()
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("WELCOME TO DELHI INTERSECTION");
                Console.WriteLine("1. Enter road");
                Console.WriteLine("2. Enter RoundAbout");
                Console.WriteLine("3. Exit RoundAbout");
                Console.WriteLine("4. Get RoundAbout Status");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        int raodId = Convert.ToInt32(Console.ReadLine());
                        int carId = Convert.ToInt32(Console.ReadLine());
                        int exitId = Convert.ToInt32(Console.ReadLine());
                        traffic.AddCarToRoad(raodId,carId,exitId);
                        break;
                    case 2:
                        int roadId = Convert.ToInt32(Console.ReadLine());
                        traffic.MoveCarToRoundabout(roadId);
                        break;
                    case 3:
                        traffic.ExitRoundabout();
                        break;
                    case 4:
                        traffic.RoundaboutStatus();
                        break;
                    default:
                        flag = false;
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}
