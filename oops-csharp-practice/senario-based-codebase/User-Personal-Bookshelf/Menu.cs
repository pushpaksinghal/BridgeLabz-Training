using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.User_Personal_Bookshelf
{
    internal class Menu
    {
        IUser utility = new Utility();
        public void start()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("WELCOME TO BOOKSHELF STOREAGE");
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
                        Console.WriteLine("Enter Passward");
                        int UserPass = Convert.ToInt32(Console.ReadLine());
                        string name = utility.UserAuth(UserPass);
                        if (name!=null)
                        {
                            userStart(name);
                            break;
                        }
                        else
                        {
                            flag = false;
                            break;
                        }
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
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Display User");
                Console.WriteLine("3. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        utility.AddUser();
                        break;
                    case 2:
                        utility.DisplayUsers();
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.Error.WriteLine("Invalid Input");
                        break;
                }
            }
        }

        public void userStart(string name)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("WELCOME USER");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Search Book");
                Console.WriteLine("3. Sort books");
                Console.WriteLine("4. Display Books");
                Console.WriteLine("5. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        utility.AddBooks(name);
                        break;
                    case 2:
                        utility.SearchBook(name);
                        break;
                    case 3:
                        utility.SortBooks(name);
                        break;
                    case 4:
                        utility.DisplayBooks(name);
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.Error.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}
