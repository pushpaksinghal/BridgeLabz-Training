using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.User_Personal_Bookshelf
{
    internal class Utility:IUser
    {
        private static int AdminPass = 14119181;
        User[] users = new User[10];
        int userCount = 0;
        static int countBook = 0;
        public void AddUser()
        {
            if (userCount < users.Length)
            {
                Console.WriteLine("Enter User Name and passward and how many books do you want");
                string name = Console.ReadLine();
                int pass = Convert.ToInt32(Console.ReadLine());
                int countBooks = Convert.ToInt32(Console.ReadLine());
                Book[] books = new Book[countBooks];
                users[userCount++] = new User(name, pass, books, countBooks);
                Console.WriteLine("User added successfully.");
            }
            else
            {
                Console.WriteLine("StoreAge is full. Cannot add more users.");
            }
        }
        public void DisplayUsers()
        {
            for(int i = 0; i < userCount; i++)
            {
                Console.WriteLine(users[i]);
            }
        }
        public void AddBooks(string name)
        {
            for(int i = 0; i < userCount; i++)
            {
                if (users[i].Name() == name && countBook < users[i].CountBooks() )
                {
                    
                    string title = Console.ReadLine();
                    string author = Console.ReadLine();
                    users[i].AddBook(new Book(title,author),countBook);
                    countBook++;
                    Console.WriteLine("Book added successfully.");
                }
            }
        }
        public void SortBooks(string name)
        {
            for (int i=0; i<userCount; i++)
            {
                if (users[i].Name() == name)
                {
                    Book[] books = users[i].Books();
                    Book[] sortedBooks = books.Where(b => b != null).OrderBy(b => b.Title()).ToArray();

                    for (int j = 0; j < sortedBooks.Length; j++)
                    {
                        books[j] = sortedBooks[j];
                    }

                }
            }
        }
        public void SearchBook(string name)
        {
            Console.WriteLine("Enter Book Auhtor to search:");
            string author = Console.ReadLine();
            for(int i = 0; i < userCount; i++)
            {
                if (users[i].Name() == name)
                {
                    Book[] books = users[i].Books();
                    for(int j = 0; j < countBook; j++)
                    {
                        if (books[j] !=null && books[j].Author().ToLower().Contains(author.ToLower()))
                        {
                            Console.WriteLine("Book found");
                            Console.WriteLine(books[j]);
                            return;
                        }
                    }
                    Console.WriteLine("Book not found");
                    return;
                }
            }
        }

        public void DisplayBooks(string name)
        {
            for (int i = 0; i < userCount; i++)
            {
                if (users[i].Name() == name)
                {
                    Book[] books = users[i].Books();
                    for (int j = 0; j < countBook; j++)
                    {
                        Console.WriteLine(books[j]);
                    }
                }
            }
        }

        public bool AdminAuth(int passward)
        {
            if (passward == AdminPass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string UserAuth(int passward)
        {
            for (int i = 0; i < userCount; i++)
            {
                if (passward == users[i].Pass())
                {
                    return users[i].Name();
                }
            }
            return null;
        }
    }
}
