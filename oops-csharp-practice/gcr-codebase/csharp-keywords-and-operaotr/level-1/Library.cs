using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.keywords_and_operator.level_1
{
    internal class Library
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("harry potter ", "jk rowling", "ISBN101");
            //is operator
            if (b1 is Book)
            {
                b1.Display();
            }
            Book.DisplayLibraryName();
        }
    }

    public class Book
    {
        //static atributes
        public static string LibraryName = "GLA  Library";
        public readonly string ISBN;

        string Title;
        string Author;

        public Book(string Title, string Author, string ISBN)
        {
            // this keyword
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
        }

        public static void DisplayLibraryName()
        {
            Console.WriteLine(LibraryName);
        }

        public void Display()
        {
            Console.WriteLine(Title + " " + Author + " " + ISBN);
        }
    }
}
