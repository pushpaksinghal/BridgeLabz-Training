using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_constructor_accessmodifiers.access_modifiers
{
    internal class BookLibrary
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            Book b2 = new Book("ARE463", "the heat of lave", "mount ain");
            EBook e1 = new EBook();

            b1.Display();
            b2.Display();
            e1.Display();
        }
    }
    public class Book
    {
        // creating the atributes
        public string ISBN;
        protected string title;
        private string author;
        // constructors
        public Book()
        {
            this.ISBN = "ISBN14213";
            this.title = "HArry Potter";
            this.author = "jk rowling";
        }
        public Book(string ISBN, string title, string author)
        {
            this.ISBN = ISBN;
            this.title = title;
            this.author = author;
        }
        // getter and setter 
        public void SetAuthor(string author)
        {
            this.author = author;
        }
        public string GetAuthor()
        {
            return author;
        }
        public void Display()
        {
            Console.WriteLine("ISBN is " + ISBN + " title is " + title + " author is " + GetAuthor());
        }
    }
    public class EBook() : Book("ISBN003", "DotNet Advanced", "Microsoft")
    {
        // display method for child class
        public void Display()
        {
            Console.WriteLine("EBook ISBN is " + ISBN + " title is " + title + " author is " + GetAuthor());
        }
    }
}
