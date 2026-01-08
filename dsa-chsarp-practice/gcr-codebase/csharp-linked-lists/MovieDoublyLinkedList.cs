using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.Linked_Lists
{
    // Doubly Linked List Node
    class MovieNode
    {
        public string Title;
        public string Director;
        public int Year;
        public double Rating;
        public MovieNode Next;
        public MovieNode Prev;
        public MovieNode(string title, string director, int year, double rating)
        {
            Title = title;
            Director = director;
            Year = year;
            Rating = rating;
            Next = null;
            Prev = null;
        }
    }
    // Doubly Linked List Class
    class MovieDoublyLinkedList
    {
        private MovieNode head;
        private MovieNode tail;
        // Add at beginning
        public void AddAtBeginning(string title, string director, int year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }
        }
        // Add at end
        public void AddAtEnd(string title, string director, int year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);
            if (tail == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
        }
        // Add at specific position (1-based)
        public void AddAtPosition(int position, string title, string director, int year, double rating)
        {
            if (position == 1)
            {
                AddAtBeginning(title, director, year, rating);
                return;
            }
            MovieNode temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
            {
                temp = temp.Next;
            }
            if (temp == null || temp.Next == null)
            {
                AddAtEnd(title, director, year, rating);
                return;
            }
            MovieNode newNode = new MovieNode(title, director, year, rating);
            newNode.Next = temp.Next;
            newNode.Prev = temp;
            temp.Next.Prev = newNode;
            temp.Next = newNode;
        }
        // Remove by Movie Title
        public void RemoveByTitle(string title)
        {
            MovieNode temp = head;
            while (temp != null && temp.Title != title)
                temp = temp.Next;
            if (temp == null)
            {
                Console.WriteLine("Movie not found");
                return;
            }
            if (temp == head)
                head = temp.Next;
            if (temp == tail)
                tail = temp.Prev;
            if (temp.Prev != null)
                temp.Prev.Next = temp.Next;
            if (temp.Next != null)
                temp.Next.Prev = temp.Prev;
            Console.WriteLine("Movie removed successfully");
        }
        // Search by Director
        public void SearchByDirector(string director)
        {
            MovieNode temp = head;
            bool found = false;
            while (temp != null)
            {
                if (temp.Director == director)
                {
                    DisplayMovie(temp);
                    found = true;
                }
                temp = temp.Next;
            }
            if (!found)
                Console.WriteLine("No movies found for this director");
        }
        // Search by Rating
        public void SearchByRating(double rating)
        {
            MovieNode temp = head;
            bool found = false;
            while (temp != null)
            {
                if (temp.Rating == rating)
                {
                    DisplayMovie(temp);
                    found = true;
                }
                temp = temp.Next;
            }
            if (!found)
                Console.WriteLine("No movies found with this rating");
        }
        // Update Rating by Title
        public void UpdateRating(string title, double newRating)
        {
            MovieNode temp = head;
            while (temp != null)
            {
                if (temp.Title == title)
                {
                    temp.Rating = newRating;
                    Console.WriteLine("Rating updated successfully");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Movie not found");
        }
        // Display forward
        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("No movie records available");
                return;
            }
            MovieNode temp = head;
            while (temp != null)
            {
                DisplayMovie(temp);
                temp = temp.Next;
            }
        }
        // Display reverse
        public void DisplayReverse()
        {
            if (tail == null)
            {
                Console.WriteLine("No movie records available");
                return;
            }

            MovieNode temp = tail;
            while (temp != null)
            {
                DisplayMovie(temp);
                temp = temp.Prev;
            }
        }
        private void DisplayMovie(MovieNode movie)
        {
            Console.WriteLine("Title: " + movie.Title + ", Director:" + movie.Director + ", Year: " + movie.Year + ", Rating: " + movie.Rating);
        }
    }

    // Main class (same file)
    class Program
    {
        public static void Main(string[] args)
        {
            MovieDoublyLinkedList movies = new MovieDoublyLinkedList();
            movies.AddAtBeginning("Inception", "Christopher Nolan", 2010, 8.8);
            movies.AddAtEnd("Interstellar", "Christopher Nolan", 2014, 8.6);
            movies.AddAtEnd("Avatar", "James Cameron", 2009, 7.8);
            movies.AddAtPosition(2, "Tenet", "Christopher Nolan", 2020, 7.5);
            Console.WriteLine("Movies (Forward):");
            movies.DisplayForward();
            Console.WriteLine("Movies (Reverse):");
            movies.DisplayReverse();
            Console.WriteLine("Search by Director: Christopher Nolan");
            movies.SearchByDirector("Christopher Nolan");
            Console.WriteLine("Update Rating of Avatar:");
            movies.UpdateRating("Avatar", 8.0);
            Console.WriteLine("Remove Movie: Tenet");
            movies.RemoveByTitle("Tenet");
            Console.WriteLine("Final Movie List:");
            movies.DisplayForward();
        }
    }
}

