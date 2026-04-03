using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_objects.BookDetail
{
    internal class BookDetail
    {
        string title;
        string author;
        double price;

        public BookDetail(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public void Display()
        {
            Console.WriteLine("the book - " + title + "by the auhtor - " + author + "is selling at " + price);
        }
    }
}
