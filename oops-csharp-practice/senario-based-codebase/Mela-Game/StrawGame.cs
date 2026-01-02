using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Mela_Game
{
    internal class StrawGame
    {
        public void Menu()
        {
            while (true)
            {
                //switch case for the menu box
                Console.WriteLine("WELCOME TO DIWALI MELA");
                Console.WriteLine("1.Play the Game");
                Console.WriteLine("2.Comtinue With the mela");

                int Choice=Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {//playing the game on repeat till tehn user exit
                    case 1:
                        Game();
                        break;
                    case 2:
                        Console.WriteLine("Come Agian later");
                        break;
                    default:
                        Console.WriteLine("invalid Choice");
                        break;

                }// if the user chooses to leave then break the while loop
                if (Choice == 2)
                {
                    break;
                }
            }
        }

        void Game()
        {
            Console.WriteLine("Pick any number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Congratulations you Won a price");
            }
            else
            {
                Console.WriteLine("Sorry try again next time");
            }
        }
    }
}
