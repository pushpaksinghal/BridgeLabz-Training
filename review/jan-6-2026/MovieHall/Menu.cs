using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.review.MovieHall
{
    internal class menu
    {
        

        public void start()
        {
            Admin a = new Admin();

            while (true)
            {
                Console.WriteLine("WELCOME TO THE MOVIE HALL");
                Console.WriteLine("1. ADMIN");
                Console.WriteLine("2. User");
                Console.WriteLine("3. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(" enter passward");
                        int passward = Convert.ToInt32(Console.ReadLine());
                        bool temp = a.verifyAdmin(passward);
                        if (temp = true)
                        {
                            AdminStart();
                        }
                        else
                        {
                            Console.WriteLine("wrong passward ");
                            break;
                        }
                        break;
                    case 2:
                        UserStart();
                        break;
                    case 3:
                        break;
                }
                if(choice == 3)
                {
                    break;
                }
            }

        }
        Admin b = new Admin();
        public void AdminStart()
        {
            
            while (true)
            {
                Console.WriteLine("Welcome admin");
                Console.WriteLine("1. See all Movies");
                Console.WriteLine("2. add a movie");
                Console.WriteLine("3. exit");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        b.seeMovies();
                        continue;
                    case 2:
                        Console.WriteLine("enter a name");
                        string name = Console.ReadLine();
                        int length = Convert.ToInt32(Console.ReadLine());
                        int numberOfTicket = Convert.ToInt32(Console.ReadLine());
                        double price = Convert.ToDouble(Console.ReadLine());

                        b.AddMovie(name,length,numberOfTicket,price);
                        continue;
                    case 3:
                        break;
                }
                if(choice == 3)
                {
                    break;
                }
            }

        }

        public void UserStart()
        {
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("enter your number");
            long number = Convert.ToInt64(Console.ReadLine());
            User u = new User(name,number);
            while (true)
            {

                Console.WriteLine("Welcome user");
                Console.WriteLine("1. See all Movies");
                Console.WriteLine("2. buy tickets");
                Console.WriteLine("3. exit");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        b.seeMovies();
                        continue;
                    case 2:
                        int howmany = Convert.ToInt32(Console.ReadLine());
                        int choose = Convert.ToInt32(Console.ReadLine());
                        u.Display();
                        b.BuyTickets(howmany,choose);
                        continue ;
                    case 3:
                        break;
                }
                if (choice == 3)
                {
                    break;
                }
            }
        }
    }
}
