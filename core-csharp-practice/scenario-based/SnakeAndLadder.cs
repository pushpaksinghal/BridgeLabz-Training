using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based
{
    
    internal class SnakeAndLadder
    {
        static Random r = new Random();
        static int[,] ladder = { { 4, 10 }, { 9, 22 }, { 20, 17 }, { 21, 21 }, { 28, 56 }, { 36, 21 }, { 51, 22 }, { 71, 11 }, { 80,19} };
        static int[,] snakes = { {49,38 }, {61,42 }, {86,62 }, {47,21 }, {58,17 }, {93,20 }, {95,020 }, {98,78 }};
        static void Main(String[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());

            if (n < 2)
            {
                Console.Error.WriteLine("Not enough player to play");
            }
            else if (n > 4)
            {
                Console.Error.WriteLine("Only four can play at a time");

            }
            else
            {
                int[] player = new int[n];
                int i = 0;
                while (true)
                {
                    Console.WriteLine($"\nPlayer {i + 1} turn:");
                    Console.WriteLine("1. roll dice");
                    Console.WriteLine("2. Quit Game");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            int x = Roll();
                            player[i] = MovePlayer(player[i], x);
                            Console.WriteLine("player " + (i + 1) + " rolled a " + x + " and moved to " + player[i]);
                            int[] newposition = SnakeOrLadder(player[i]);
                            if (newposition[1] == 1)
                            {
                                player[i] = newposition[0];
                                Console.WriteLine("player " + (i + 1) + " found a Ladder. and moved to " + player[i]);
                            }
                            else if (newposition[1] == 2)
                            {
                                player[i] = newposition[0];
                                Console.WriteLine("player " + (i + 1) + " found a Snake.and moved to " + player[i]);
                            }
                            if (i < n - 1)
                            {
                                i++;
                            }
                            else
                            {
                                i = 0;
                            }
                            continue;

                        case 2:
                            Console.WriteLine("player "+(i + 1) + "has left the game");
                            break;
                        default:
                            Console.WriteLine("invalid choise");
                            break;
                    }
                    
                    if(choice == 2)
                    {
                        Console.WriteLine("Game Over");
                        break;
                    }
                    
                    else if (CheckWin(player[i]))
                    {

                        Console.WriteLine("the player how Won is player " + (i + 1));
                        break;
                    }
                }
            }
            
        }

        static int Roll()
        {
            return r.Next(1, 7);
        }
        static int MovePlayer(int inital, int rolled)
        {
            if((inital + rolled) <= 100)
            {
                return inital + rolled;
            }
            else
            {
                return inital;
            }
        }

        static int[] SnakeOrLadder(int position)
        {
            int newPosition = position;
            int a = 0;
            for(int i = 0; i < 9; i++)
            {
                if (position == ladder[i, 0])
                {
                    a = 1;
                    newPosition= position + ladder[i, 1];
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (position == snakes[i, 0])
                {
                    a = 2;
                    newPosition= position - snakes[i, 1];
                }
            }

            return new int[] {newPosition,a};
        }
        static bool CheckWin(int position)
        {
            if (position == 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
