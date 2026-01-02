using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_constructor_accessmodifiers.level_1
{
    internal class CarRental
    {
        //created the atributes
        string userName;
        string carModel;
        int days;

        //default con
        public CarRental()
        {
            this.days = 0;
            this.userName = "jhon";
            this.carModel = "gr";
        }
        //parameter con
        public CarRental(string userName, string carModel, int days)
        {
            this.userName = userName;
            this.carModel = carModel;
            this.days = days;
        }
        // price calculator methods
        public void price()
        {
            Console.WriteLine("the totle price is " + (days * 5));
        }

    }

    class Display()
    {
        static void Main(string[] args)
        {
            // calling tjhe class in main
            CarRental c1 = new CarRental("pushpak", "car2020", 20);
            c1.price();
        }
    }
}
