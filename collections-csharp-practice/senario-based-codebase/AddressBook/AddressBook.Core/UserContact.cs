using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.AddressBook
{
    public class UserContact
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zip;
        private string phoneNumber;
        private string email;

        public UserContact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public string FirstName( ) { return firstName; }
        public string LastName( ) { return lastName; }
        public string Address( ) { return address; }
        public string City( ) { return city; }
        public string State( ) { return state; }
        public string Zip( ) { return zip; }
        public string PhoneNumber( ) { return phoneNumber; }
        public string Email( ) { return email; }

        public override string ToString( )
        {
            return "Name: " + firstName + " " + lastName + "\nAddress: " + address + ", " + city + ", " + state + " - " + zip + "\nPhone Number: " + phoneNumber + "\nEmail: " + email;
        }
    }
}
