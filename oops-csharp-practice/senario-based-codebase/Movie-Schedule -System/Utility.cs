using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Movie_Schedule__System
{
    internal class Utility: IMovies
    {
        private static  int Adminpass = 14119181;
        Movie[] movies = new Movie[10];
        int count = 0;

        public void AddMovie()
        {
            
            Console.WriteLine("Enter Movie title and ShowTime");
            string title = Console.ReadLine();
            string input = Console.ReadLine();
            DateTime showTime = DateTime.ParseExact(input, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            movies[count] = new Movie(title, showTime);
            count++;

            Console.WriteLine("Movie added.");
        }

        public void ViewMovies()
        {
            Console.WriteLine("All the movie in the cenima");
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(movies[i]);
            }
        }

        public void SearchMovie(string title)
        {
            for(int i=0; i < count; i++)
            {
                if (movies[i].Title().Contains(title.ToLower()))
                {
                    Console.WriteLine(movies[i]);
                    break;
                }
                else
                {
                    Console.WriteLine("There is no movie with this name.");
                }
            }
        }

        public bool AdminAuth(int passward)
        {
            if(passward == Adminpass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
