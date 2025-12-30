using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based
{
    internal class LibraryManagementSystem
    {
        //making hte passward static and private
        private static string passward = "Nowiamdeath";
        static void Main(String[]args)
        {
            // amingthe obj for the class 
            LibraryManagementSystem obj = new LibraryManagementSystem();
            // taking input of all the books
            string[,] books = obj.InputBook();
            // check the auth if the user is admin or not
            obj.CheckAuth(books);
        }
        void CheckAuth(string[,]books)
        {
            
            
            while (true)
            {
                Console.WriteLine("WELCOME TO THEE LIBRARY");
                Console.WriteLine("1. Admin Login");
                Console.WriteLine("2. user Login");
                Console.WriteLine("3. Exit");
                int auth = Convert.ToInt32(Console.ReadLine());
                switch (auth)
                {
                    case 1:
                        // if admin give pass and check it 
                        string userEntry = Console.ReadLine();
                        if (Passward(userEntry))
                        {
                            DisplayAdmin(books, books.GetLength(0));
                            return;
                        }
                        else
                        // end program
                        {
                            Console.WriteLine("You do not have admin status");
                            break;
                        }
                    case 2:
                        // show the option for user
                        DisplayUser(books, books.GetLength(0));
                        break;
                    case 3:
                        Console.WriteLine("Goodbye!");
                        return;
                }
                if(auth == 3)
                {
                    break;
                }
            }   
        }
        private bool Passward(string userEntry)
        {
            
            // passward checker
            if (string.Equals(userEntry, passward))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        string[,] InputBook()
        {
            //takes the input for all the books wiht there title and author andd cat and status
            Console.WriteLine("renter the number of book to add in a library");
            int n = Convert.ToInt32(Console.ReadLine());
            string[,] books = new string[n, 4]; 
            for(int i = 0; i < n; i++)
            {
                books[i, 0] = Console.ReadLine();//title
                books[i, 1] = Console.ReadLine();//author
                books[i, 2] = Console.ReadLine();//categories
                books[i, 3] = Console.ReadLine();//status
            }

            return books;
        }
        void SeeBooks(String[,] books, int n)
        {
            // user or admin can see all the books
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(books[i, 0]);
            }
        }

        int Searching(string[,]books, int n)
        {
            // can search fora  book and check if that book is checked out or not
            string userSearch = Console.ReadLine();
            int temp =-1 ;
            userSearch = userSearch.Trim().ToLower();
            for(int i = 0; i < n; i++)
            {
                if (books[i, 0].Equals(userSearch, StringComparison.OrdinalIgnoreCase) || books[i, 1].Equals(userSearch, StringComparison.OrdinalIgnoreCase))
                {
                    temp = i;
                    if (string.Equals(books[i,3],"checked out"))
                    {
                        Console.WriteLine(books[i, 0] + "is present in the library but is checked out ");
                    }
                    Console.WriteLine(books[i, 0] + "is present in the library and is avalible ");
                } 
            }
            return temp;
        }

        void RentingBook(string[,]books,int n,int index)
        {
            // user can rent a book
            if (books[index, 3].Equals("check out", StringComparison.OrdinalIgnoreCase))
            {
                books[index, 3] = "checked out";
                Console.WriteLine("You have rented the book" + books[index, 0]);
            }
            Console.WriteLine("You can not rent the book" + books[index, 0]);
        }

        private void Changepassward()
        {
            // admin can change the passward
            passward= Console.ReadLine();
        }
        private string[,] ResizeArray(string[,] oldArray, int newRows, int cols)
        {
            // if add ing or removeing a book we can resize the array
            string[,] newArray = new string[newRows, cols];

            int oldRows = oldArray.GetLength(0);

            for (int i = 0; i < oldRows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    newArray[i, j] = oldArray[i, j];
                }
            }

            return newArray;
        }

        private string[,] AddBook(String[,] books)
        {
            //can add books
            int rows = books.GetLength(0);
            int cols = books.GetLength(1);
            books = ResizeArray(books, rows+1,cols);

            books[rows, 0] = Console.ReadLine(); ;
            books[rows, 1] = Console.ReadLine(); ;
            books[rows, 2] = Console.ReadLine(); ;
            books[rows, 3] = Console.ReadLine(); ;

            return books;
        }

        private string[,] RemoveBook(String[,] books,int index)
        {
            // admin can remove the book
            int rows = books.GetLength(0);
            int cols = books.GetLength(1);
            if (index < 0 || index >= rows)
            {
                Console.WriteLine("Invalid book index");
                return books;
            }
            int lastRow = rows - 1;
            books[index, 0] = books[lastRow, 0];
            books[index, 1] = books[lastRow, 1];
            books[index, 2] = books[lastRow, 2];
            books[index, 3] = books[lastRow, 3];
            books = ResizeArray(books, rows -1, cols);

            return books;
        }

        void DisplayUser(string[,] books, int n)
        {
            // for user
            while (true)
            {
                Console.WriteLine("WELCOME USER");
                Console.WriteLine("1. See all the books");
                Console.WriteLine("2. Search for a book (by title or author)");
                Console.WriteLine("3. Rent the book ");
                Console.WriteLine("4. exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                int indexOfSearchedBook = -1;
                switch (choice)
                {
                    case 1:
                        SeeBooks(books, n);
                        continue;
                    case 2:
                        indexOfSearchedBook=Searching(books, n);
                        continue;
                    case 3:
                        if(indexOfSearchedBook != -1)
                        {
                            RentingBook(books, n, indexOfSearchedBook);
                        }
                        else
                        {
                            Console.WriteLine("this book has already been checked out");
                        }
                        continue ;
                    case 4:
                        Console.WriteLine("Thanks for visiting.");
                        break;
                }
                if(choice == 4)
                {
                    break;
                }
            }
        }

        void DisplayAdmin(String[,]books ,int n)
        {
            // for admin
            while (true)
            {
                Console.WriteLine("WELCOME ADMIN");
                Console.WriteLine("1. See all the books");
                Console.WriteLine("2. Search for a book (by title or author)");
                Console.WriteLine("3. Change Passward");
                Console.WriteLine("4. Add A Book");
                Console.WriteLine("5. Remove a Book");
                Console.WriteLine("6. exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                int indexOfSearchedBook = -1;
                switch (choice)
                {
                    case 1:
                        SeeBooks(books, n);
                        continue;
                    case 2:
                        indexOfSearchedBook = Searching(books, n);
                        continue;
                    case 3:
                        Changepassward();
                        continue;
                    case 4:
                        books=AddBook(books);
                        n = books.GetLength(0);
                        continue;
                    case 5:
                        books =RemoveBook(books,indexOfSearchedBook);
                        continue;
                    case 6:
                        Console.WriteLine("Done the days work");
                        break;
                    default:
                        break;
                }
                

            }

        }

    }
}
