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
        IAddressBook addressBook = new AddressUtility();

        public void Start()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("WELCOME TO ADDRESS BOOK PROGRAM");
                Console.WriteLine("1.Add Address Book");
                Console.WriteLine("2.See all the Address Books");
                Console.WriteLine("3.Enter a Address Book");
                Console.WriteLine("4.Search person accross all the address books");// searching a person accross mulpitle address book UC-8
                Console.WriteLine("5.Exit");

                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        addressBook.AddAddressBook();
                        break;
                    case 2:
                        addressBook.ShowAddressBook();
                        break;
                    case 3:
                        string ownerName = Console.ReadLine();
                        if (addressBook.OwnerEntry(ownerName))
                        {
                            AddressStarter(ownerName);
                            break;
                        }
                        else
                        {
                            flag = false;
                            Console.WriteLine("There is no owner in the name of " + ownerName);
                            break;
                        }
                    case 4:
                        addressBook.SearchPersonByCityOrState();
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        flag = false;
                        Console.Error.WriteLine("Invalid Input");
                        break;
                }
            }
        }
        public void AddressStarter(string name)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("WELCOME OWNER");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Add Contact of whole Family");// updated the menu according to the ask of the UC-5
                Console.WriteLine("3. Show Contact");
                Console.WriteLine("4. Update Contact");// updated the menu according to the ask of the UC -3
                Console.WriteLine("5. Delete Contact");// updated the menu according to the ask of the UC-4
                Console.WriteLine("6. View all teh people in a perticular state or city");// updated the menu according to the ask of the UC-9
                Console.WriteLine("7. Totle number of people in that city or state"); // updated the menu according to the ask of the UC-10
                Console.WriteLine("8. Sort the Address Book Alphabaticlly"); // updated the menu according to the ask of UC-11
                Console.WriteLine("9. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addressBook.AddContact(name);
                        break;
                    case 2:
                        addressBook.AddContactsOfFamily(name);
                        break;
                    case 3:
                        addressBook.ShowContact(name);
                        break;
                    case 4:
                        addressBook.EditContact(name);
                        break;
                    case 5:
                        addressBook.DeleteContact(name);
                        break;
                    case 6:
                        addressBook.ViewAllByCityOrState(name);
                        break;
                    case 7:
                        addressBook.CountByCityOrState(name);
                        break;
                    case 8:
                        addressBook.SortContactsAlphabetically(name);
                        break;
                    case 9:
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
