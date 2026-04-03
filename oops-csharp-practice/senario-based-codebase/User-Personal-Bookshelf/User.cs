using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.User_Personal_Bookshelf
{
    internal class User
    {
        private string name;
        private int Userpass;
        private int countBooks;
        private Book[] books;

        public User(string name, int Userpass, Book[]books, int countBooks)
        {
            this.name = name;
            this.Userpass = Userpass;
            this.books = books;
            this.countBooks = countBooks;
        }

        public string Name() { return name; }
        public int Pass() { return Userpass; }
        public int CountBooks() { return countBooks; }
        public Book[] Books() { return books; }

        public void AddBook(Book book, int index)
        {
            books[index] = book;
        }
        public override string ToString()
        {
            return "Name: " + name + "\nPassword: " + Userpass;
        }
    }
}
