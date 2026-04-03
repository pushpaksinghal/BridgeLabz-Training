using BridgelabzTraining.senario_based.AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Tests.Helper
{
    internal static class ContactFactory
    {
        public static UserContact Create(string firstName = "Pushpak",string lastName = "Singhal",string city = "Hapur",string state = "UP" , string zip = "411001")
        {
            return new UserContact(
                firstName,
                lastName,
                "ShivPuri",
                city,
                state,
                zip,
                "8979857625",
                "pushpkasinghal1234@Tmail.com");
        }
    }
}
