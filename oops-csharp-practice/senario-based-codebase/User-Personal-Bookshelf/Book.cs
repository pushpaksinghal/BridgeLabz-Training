using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.User_Personal_Bookshelf
{
    internal class Book
    {
        private string title;
        private string author;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
        public string Title() { return title; }
        public string Author() { return author; }

        public override string ToString()
        {
            return "Title: " + title + "\nAuthor: " + author;
        }
    }
}
