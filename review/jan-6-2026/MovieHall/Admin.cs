using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.review.MovieHall
{
    internal class Admin
    {
        public Movie[] movie;
        private int count;
        private int pass = 9090;
        public Admin()
        {
            movie = new Movie[2];
            count = 0;
        }

        public void AddMovie(string name,int length,int numberOfTickets,double price)
        {
            if(count < movie.Length)
            {
                movie[count] = new Movie(name, length, numberOfTickets, price);
                count++;
            }
            else
            {
                Console.WriteLine("can not add more movies ");
            }
        }

        public void BuyTickets(int tickets,int index)
        {
            if (movie[index].numberOfTicket > tickets)
            {

                movie[index].numberOfTicket -= tickets;
                Console.WriteLine("the total price is " + (movie[index].price * tickets));
            }
            else
            {
                Console.WriteLine("not enough ticket left");
            }
        }


        public bool verifyAdmin(int passward)
        {
            if(passward == pass)
            {

                return true;
            }
            return false;
        }


        public void seeMovies()
        {
            if (count == 0)
            {
                Console.WriteLine("No movies");
                return;
            }

            int i = 0;
            while (i < count)
            {
                Console.WriteLine((i + 1) + ". " + movie[i].name);
                Console.WriteLine("Tickets: " + movie[i].numberOfTicket);
                i++;
            }
        }
    }
}
