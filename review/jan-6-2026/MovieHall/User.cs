using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.review.MovieHall
{
    internal class User
    {
        string userName;
        long mobileNumber;

        public User(string userName, long mobileNumber)
        {
            this.userName = userName;
            this.mobileNumber = mobileNumber;
        }

        public void Display()
        {
            Console.WriteLine("name" + userName);
            Console.WriteLine("number " + mobileNumber);
        }
    }
}
