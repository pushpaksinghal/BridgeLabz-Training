using System;
using System.Collections.Generic;
using BridgelabzTraining.senario_based.AddressBook; // Core namespace

namespace BridgelabzTraining.senario_based.AddressBook
{
    internal class AddressMenu
    {
        private readonly IAddressBook addressBook = new AddressUtility<UserContact>();

        public void Start()
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("\nWELCOME TO ADDRESS BOOK PROGRAM");
                    Console.WriteLine("1. Add Address Book");
                    Console.WriteLine("2. See all the Address Books");
                    Console.WriteLine("3. Enter an Address Book");
                    Console.WriteLine("4. Search person across all the address books");
                    Console.WriteLine("5. Exit");

                    if (!int.TryParse(Console.ReadLine(), out int choice))
                        throw new FormatException("Invalid menu choice");

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Owner Name: ");
                            addressBook.AddAddressBook(Console.ReadLine());
                            break;

                        case 2:
                            ShowAllAddressBooks();
                            break;

                        case 3:
                            Console.Write("Enter Owner Name: ");
                            string owner = Console.ReadLine();

                            if (!addressBook.OwnerEntry(owner))
                                throw new AddressBookNotFoundException(owner);

                            AddressStarter(owner);
                            break;

                        case 4:
                            SearchAcrossAllBooksUI();
                            break;

                        case 5:
                            flag = false;
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void AddressStarter(string ownerName)
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("\nWELCOME OWNER");
                    Console.WriteLine("1. Add Contact");
                    Console.WriteLine("2. Add Contact of whole Family");
                    Console.WriteLine("3. Show Contact");
                    Console.WriteLine("4. Update Contact");
                    Console.WriteLine("5. Delete Contact");
                    Console.WriteLine("6. View by city/state");
                    Console.WriteLine("7. Count by city/state");
                    Console.WriteLine("8. Sort Alphabetically");
                    Console.WriteLine("9. Sort by City");
                    Console.WriteLine("10. Sort by State");
                    Console.WriteLine("11. Sort by Zip");
                    Console.WriteLine("12. Save Address Book to File");
                    Console.WriteLine("13. Load Address Book from File");
                    Console.WriteLine("14. Save Address Book to CSV File");
                    Console.WriteLine("15. Load Address Book from CSV File");
                    Console.WriteLine("16. Save Address Book to Json File");
                    Console.WriteLine("17. Load Address Book From Json File");
                    Console.WriteLine("16. Exit");

                    if (!int.TryParse(Console.ReadLine(), out int choice))
                        throw new FormatException("Invalid menu choice");

                    switch (choice)
                    {
                        case 1:
                            addressBook.AddContact(ownerName, ReadContactFromConsole());
                            break;

                        case 2:
                            AddFamilyUI(ownerName);
                            break;

                        case 3:
                            ShowContactsUI(ownerName);
                            break;

                        case 4:
                            EditContactUI(ownerName);
                            break;

                        case 5:
                            DeleteContactUI(ownerName);
                            break;

                        case 6:
                            ViewByCityOrStateUI(ownerName);
                            break;

                        case 7:
                            CountByCityOrStateUI(ownerName);
                            break;

                        case 8:
                            addressBook.SortContactsAlphabetically(ownerName);
                            Console.WriteLine("Sorted successfully.");
                            break;

                        case 9:
                            addressBook.SortContactsByCity(ownerName);
                            ShowContactsUI(ownerName);
                            break;

                        case 10:
                            addressBook.SortContactsByState(ownerName);
                            ShowContactsUI(ownerName);
                            break;

                        case 11:
                            addressBook.SortContactsByZip(ownerName);
                            ShowContactsUI(ownerName);
                            break;

                        case 12:
                            Console.Write("Enter file path to save: ");
                            string savePath = Console.ReadLine();
                            addressBook.SaveAddressBookToFile(ownerName, savePath);
                            Console.WriteLine("Saved successfully.");
                            break;

                        case 13:
                            Console.Write("Enter file path to load: ");
                            string loadPath = Console.ReadLine();
                            addressBook.LoadAddressBookFromFile(ownerName, loadPath);
                            Console.WriteLine("Loaded successfully.");
                            break;

                        case 14:
                            Console.Write("Enter CSV file path to export: ");
                            addressBook.ExportToCsv(ownerName, Console.ReadLine());
                            Console.WriteLine("Exported to CSV.");
                            break;

                        case 15:
                            Console.Write("Enter CSV file path to import: ");
                            addressBook.ImportFromCsv(ownerName, Console.ReadLine());
                            Console.WriteLine("Imported from CSV.");
                            break;
                        case 16:
                            Console.Write("Enter JSON file path to export: ");
                            addressBook.ExportToJson(ownerName, Console.ReadLine());
                            Console.WriteLine("Exported to JSON.");
                            break;

                        case 17:
                            Console.Write("Enter JSON file path to import: ");
                            addressBook.ImportFromJson(ownerName, Console.ReadLine());
                            Console.WriteLine("Imported from JSON.");
                            break;

                        case 18:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //Helper Methods

        private void ShowAllAddressBooks()
        {
            var owners = addressBook.GetAllAddressBookOwners();
            if (owners.Count == 0)
            {
                Console.WriteLine("No address books found.");
                return;
            }

            foreach (var owner in owners)
                Console.WriteLine(owner);
        }

        private UserContact ReadContactFromConsole()
        {
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("State: ");
            string state = Console.ReadLine();

            Console.Write("Zip: ");
            string zip = Console.ReadLine();

            Console.Write("Phone Number: ");
            string phone = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            return new UserContact(firstName, lastName, address, city, state, zip, phone, email);
        }

        private void AddFamilyUI(string ownerName)
        {
            Console.Write("How many contacts to add? ");
            int count = Convert.ToInt32(Console.ReadLine());

            List<UserContact> contacts = new();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nContact #{i + 1}");
                contacts.Add(ReadContactFromConsole());
            }

            addressBook.AddContactsOfFamily(ownerName, contacts);
        }

        private void ShowContactsUI(string ownerName)
        {
            var contacts = addressBook.GetContacts(ownerName);
            if (contacts.Count == 0)
                throw new ContactNotFoundException("No contacts");

            foreach (var c in contacts)
                Console.WriteLine(c);
        }

        private void EditContactUI(string ownerName)
        {
            Console.Write("Enter First Name to edit: ");
            string fn = Console.ReadLine();

            Console.Write("Enter Last Name to edit: ");
            string ln = Console.ReadLine();

            Console.WriteLine("Enter new details:");
            UserContact updated = ReadContactFromConsole();

            addressBook.EditContact(ownerName, fn, ln, updated);
            Console.WriteLine("Updated successfully.");
        }

        private void DeleteContactUI(string ownerName)
        {
            Console.Write("Enter First Name to delete: ");
            string fn = Console.ReadLine();

            Console.Write("Enter Last Name to delete: ");
            string ln = Console.ReadLine();

            addressBook.DeleteContact(ownerName, fn, ln);
            Console.WriteLine("Deleted successfully.");
        }

        private void ViewByCityOrStateUI(string ownerName)
        {
            Console.Write("Enter City or State: ");
            string cityOrState = Console.ReadLine();

            var results = addressBook.FilterByCityOrState(ownerName, cityOrState);
            if (results.Count == 0)
            {
                Console.WriteLine("No matching contacts found.");
                return;
            }

            foreach (var c in results)
                Console.WriteLine(c);
        }

        private void CountByCityOrStateUI(string ownerName)
        {
            Console.Write("Enter City or State: ");
            string cityOrState = Console.ReadLine();

            int count = addressBook.CountByCityOrState(ownerName, cityOrState);
            Console.WriteLine("Total contacts: " + count);
        }

        private void SearchAcrossAllBooksUI()
        {
            Console.Write("Enter First Name: ");
            string fn = Console.ReadLine();

            Console.Write("Enter City or State: ");
            string cityOrState = Console.ReadLine();

            var results = addressBook.SearchAcrossBooks(fn, cityOrState);
            if (results.Count == 0)
            {
                Console.WriteLine("No matches found across address books.");
                return;
            }

            foreach (var r in results)
            {
                Console.WriteLine("Address Book: " + r.Owner);
                Console.WriteLine(r.Contact);
            }
        }
    }
}
