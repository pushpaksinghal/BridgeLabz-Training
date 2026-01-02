using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_constructor_accessmodifiers.level_1
{
    internal class Book
    {
        // created the atributes
        string title;
        string author;
        double price;

        // default con
        public Book()
        {
            this.title = "the heat of lave";
            this.author = "mount ain";
            this.price = 77.99;
        }
        //Parameter con
        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }
        // display method
        public void Display()
        {
            Console.WriteLine("the title of the book is " + title);
            Console.WriteLine(" the author is " + author);
            Console.WriteLine(" buy it for just rupees " + price);
        }

    }

    class Display()
    {

        // calling the class  in main
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Display();

            Book book2 = new Book("Harry Potter", "j.K.Rowling", 12.99);
            book2.Display();
        }
    }
}
