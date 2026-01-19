using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.review.MovieHall
{
    internal class Movie
    {
        public string name;
        public int length;
        public int numberOfTicket;
        public double price;

        public Movie(string name, int length, int numberOfTicket,double price)
        {
            this.name = name;
            this.length = length;
            this.numberOfTicket = numberOfTicket;  
            this.price = price;
        }

        public void Display()
        {
            Console.WriteLine("Movie name " + name);
            Console.WriteLine("length " + length);
            Console.WriteLine("Tickets Left " + numberOfTicket);
            Console.WriteLine("Price " + price);
        }
    }
}
