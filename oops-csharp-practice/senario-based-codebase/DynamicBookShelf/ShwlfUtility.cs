using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.DynamicBookShelf
{
    internal class ShwlfUtility: IBooks
    {
        Dictionary<string,ShelfBooks>library = new Dictionary<string,ShelfBooks>();

        public void AddBook()
        {
            String name = Console.ReadLine();
            String author = Console.ReadLine();
            String genre = Console.ReadLine();
            bool status = true; ;

            Book book = new Book(name, author, genre, status);
            if (library.ContainsKey(genre.ToLower())) 
            {
                library[genre.ToLower()].Add(book);
            }
            else
            {
                library[genre.ToLower()] = new ShelfBooks();
                library[genre.ToLower()].Add(book);
            }

            Console.WriteLine("Book Added to the perticular genre shelf");
        }

        public void DeleteBook()
        {
            string name = Console.ReadLine(); 
            string genre = Console.ReadLine();
            if (library.ContainsKey(genre.ToLower()))
            {
                bool deleted = library[genre.ToLower()].Remove(name);
                if (deleted)
                {
                    Console.WriteLine("Book Deleted.");
                }
                else
                {
                    Console.WriteLine("no bbook with this name");
                }
            }
            else
            {
                Console.WriteLine("there is no book  to delete");
            }
        }

        public void DisplayByGenre()
        {
            string genre = Console.ReadLine();
            if (library.ContainsKey(genre.ToLower()))
            {
                library[genre.ToLower()].Display();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Add this genrebooks to display all the books");
            }
        }

        public void UpdateStatus()
        {
            string genre = Console.ReadLine();
            string name = Console.ReadLine();
            if (library.ContainsKey(genre.ToLower()))
            {
                library[genre.ToLower()].Update(name);
                return;
            }
            else
            {
                Console.WriteLine("This genre des not exist");
            }
        }
    }
}
