using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.AddressBook
{
    internal class AddressMenu
    {
        // making a object of AddresBook from teh signature of Interface
        IAddressBook addressBook;

        public void AddressStarter()
        {
            // taking input of the owner of the addresbook
            Console.WriteLine("Enter Owner name and Book Size");
            string ownerName = Console.ReadLine();
            int size = Convert.ToInt32(Console.ReadLine());
            AddressBook book = new AddressBook(size, ownerName);
            addressBook = new AddressUtility(book);
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("WELCOME TO THE ADDRESS BOOK PROGRAM");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Add Contact of whole Family");// updated the menu according to the ask of the UC-5
                Console.WriteLine("3. Show Contact");
                Console.WriteLine("4. Update Contact");// updated the menu according to the ask of the UC -3
                Console.WriteLine("5. Delete Contact");// updated the menu according to the ask of the UC-4
                Console.WriteLine("6. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addressBook.AddContact();
                        break;
                    case 2:
                        addressBook.AddContactsOfFamily();
                        break;
                    case 3:
                        addressBook.ShowContact();
                        break;
                    case 4:
                        addressBook.EditContact();
                        break;
                    case 5:
                        addressBook.DeleteContact();
                        break;
                    case 6:
                        flag =false;
                        break;
                    default:
                        flag = false;
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}
