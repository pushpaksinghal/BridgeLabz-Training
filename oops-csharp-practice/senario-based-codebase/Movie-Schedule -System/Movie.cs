using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Movie_Schedule__System
{
    internal class Movie
    {
        private string title;
        private DateTime showTime;

        public Movie(string title, DateTime showTime)
        {
            this.title = title;
            this.showTime = showTime;
        }
        public string Title() { return title; }
        public DateTime ShowTime() { return showTime; }

        public override string ToString()
        {
            return "Title: " + title + "\nShowTime: " + showTime;
        }
    }

}
