using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_constructor_accessmodifiers.Instance_vs_class
{
    internal class CarRental
    {
        //atributes
        static int fee =3000;
        string userName;
        string vehicleType;
        //construtor
        public CarRental(string userName, string vehicleType)
        {
            this.userName = userName;
            this.vehicleType = vehicleType;
        }
        //display method
        public void DisplayVehicleDetails()
        {
            Console.WriteLine("the owner of the car is " + userName + "the vehicle type is " + vehicleType);
        }
        //updateing the fee for course rig
        static public void UpdateRegistrationFee(int newfee)
        {
            fee = newfee;
            Console.WriteLine("the new fee is " + fee);
        }
        
    }

    class display()
    {
        static void Main(String [] args)
        {
            CarRental c1 = new CarRental("pushpak", "toyota");
            c1.DisplayVehicleDetails();
            CarRental.UpdateRegistrationFee(5000);
        }
    }
}
