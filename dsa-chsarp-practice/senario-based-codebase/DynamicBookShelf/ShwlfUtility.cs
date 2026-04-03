using System;

namespace BridgelabzTraining.senario_based.DynamicBookShelf
{
    internal class ShwlfUtility : IBooks
    {
        private const int MAX_GENRES = 20;

        private string[] genres = new string[MAX_GENRES];
        private ShelfBooks[] shelves = new ShelfBooks[MAX_GENRES];
        private int genreCount = 0;
        // helper function for finding the genre
        private int FindGenreIndex(string genre)
        {
            genre = genre.ToLower();
            for (int i = 0; i < genreCount; i++)
            {
                if (genres[i] == genre)
                    return i;
            }
            return -1;
        }

        public void AddBook()
        {
            string name = Console.ReadLine();
            string author = Console.ReadLine();
            string genre = Console.ReadLine().ToLower();
            bool status = true;

            Book book = new Book(name, author, genre, status);

            int index = FindGenreIndex(genre);

            if (index != -1)
            {
                shelves[index].Add(book);
            }
            else
            {
                if (genreCount >= MAX_GENRES)
                {
                    Console.WriteLine("Genre limit reached.");
                    return;
                }

                genres[genreCount] = genre;
                shelves[genreCount] = new ShelfBooks();
                shelves[genreCount].Add(book);
                genreCount++;
            }

            Console.WriteLine("Book added to the particular genre shelf.");
        }

        public void DeleteBook()
        {
            string name = Console.ReadLine();
            string genre = Console.ReadLine().ToLower();

            int index = FindGenreIndex(genre);

            if (index != -1)
            {
                bool deleted = shelves[index].Remove(name);
                Console.WriteLine(deleted ? "Book deleted." : "No book with this name.");
            }
            else
            {
                Console.WriteLine("This genre does not exist.");
            }
        }

        public void DisplayByGenre()
        {
            string genre = Console.ReadLine().ToLower();
            int index = FindGenreIndex(genre);

            if (index != -1)
            {
                shelves[index].Display();
            }
            else
            {
                Console.WriteLine("No books found for this genre.");
            }
        }

        public void UpdateStatus()
        {
            string genre = Console.ReadLine().ToLower();
            string name = Console.ReadLine();

            int index = FindGenreIndex(genre);

            if (index != -1)
            {
                shelves[index].Update(name);
            }
            else
            {
                Console.WriteLine("This genre does not exist.");
            }
        }
    }
}
