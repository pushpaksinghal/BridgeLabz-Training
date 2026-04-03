using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.keywords_and_operator.level_1
{
    internal class Rto
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle("pushpak", "car", 1411);
            // is operator if true then display 
            if (v1 is Vehicle)
            {
                v1.Display();
            }
            // updating the fee
            Vehicle.UpdateRegistrationFee(2000);
        }
    }

    public class Vehicle
    {
        public static int RegistrationFee = 1500;
        // readonly variable
        public readonly int RegistrationNumber;

        string OwnerName;
        string VehicleType;
        // parameter con
        public Vehicle(string OwnerName, string VehicleType, int RegistrationNumber)
        {
            // this keyword
            this.OwnerName = OwnerName;
            this.VehicleType = VehicleType;
            this.RegistrationNumber = RegistrationNumber;
        }

        public static void UpdateRegistrationFee(int fee)
        {
            RegistrationFee = fee;
            Console.WriteLine(RegistrationFee);
        }

        public void Display()
        {
            Console.WriteLine(OwnerName + " " + VehicleType + " " + RegistrationNumber);
        }
    }
}
