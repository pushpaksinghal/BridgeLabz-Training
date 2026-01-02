using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_constructor_accessmodifiers.level_1
{
    internal class HotelBooking
    {
        //created the atributes
        string name;
        string roomType;
        int nights;
        //default con
        public HotelBooking()
        {
            this.name = "jhon doe";
            this.roomType = "basic";
            this.nights = 1;
        }

        //parameter con

        public HotelBooking(string name, string roomType, int nights)
        {
            this.name = name;
            this.roomType = roomType;
            this.nights = nights;
        }
        //copy con
        public HotelBooking(HotelBooking previous)
        {
            this.name = previous.name;
            this.roomType = previous.roomType;
            this.nights = previous.nights;
        }
        // display method
        public void Display()
        {
            Console.WriteLine("the room is " + roomType + " booked by " + name + " for " + nights + " nights");
        }

    }

    class Display()
    {
        static void Main(String[] args)
        {
            // calling the class in main
            HotelBooking r1 = new HotelBooking();
            r1.Display();

            HotelBooking r2 = new HotelBooking("pushpak singhal", "gold", 3);
            r2.Display();

            HotelBooking r3 = new HotelBooking(r2);
            r3.Display();
        }
    }
}
