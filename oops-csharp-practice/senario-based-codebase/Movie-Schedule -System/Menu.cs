using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Movie_Schedule__System
{
    internal class Menu
    {
        Utility utility = new Utility();
        public void start()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("WELCOME TO CENIMATIME");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. User");
                Console.WriteLine("3. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Passward");
                        int passward = Convert.ToInt32(Console.ReadLine());
                        if (utility.AdminAuth(passward))
                        {
                            adminStart();
                            break;
                        }
                        else
                        {
                            flag = false;
                            break;
                        }

                    case 2:
                        userStart();
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.Error.WriteLine("Invalid Input");
                        flag = false;
                        break;
                }
            }
        }

        public void adminStart()
        {   
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("WELCOME ADMIN");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. View All Movies");
                Console.WriteLine("3. Search Movie");
                Console.WriteLine("4. Exit");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        utility.AddMovie();
                        break;
                    case 2:
                        utility.ViewMovies();
                        break;
                    case 3:
                        string title = Console.ReadLine();
                        utility.SearchMovie(title);
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.Error.WriteLine("Invalid Input");
                        flag = false;
                        break;
                }
            }
        }

        public void userStart()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("WELCOME USER");
                Console.WriteLine("1. View All Movies");
                Console.WriteLine("2. Search Movie");
                Console.WriteLine("3. Exit");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        utility.ViewMovies();
                        break;
                    case 2:
                        string title = Console.ReadLine();
                        utility.SearchMovie(title);
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.Error.WriteLine("Invalid Input");
                        flag = false;
                        break;
                }
            }
        }
    }
}
