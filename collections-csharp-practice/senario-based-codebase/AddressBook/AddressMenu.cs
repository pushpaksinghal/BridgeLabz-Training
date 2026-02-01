namespace BridgelabzTraining.senario_based.AddressBook
{
    internal class AddressMenu
    {
        IAddressBook addressBook = new AddressUtility<UserContact>();

        public void Start()
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("WELCOME TO ADDRESS BOOK PROGRAM");
                    Console.WriteLine("1.Add Address Book");
                    Console.WriteLine("2.See all the Address Books");
                    Console.WriteLine("3.Enter a Address Book");
                    Console.WriteLine("4.Search person accross all the address books");
                    Console.WriteLine("5.Exit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: 
                            addressBook.AddAddressBook(); 
                            break;
                        case 2: 
                            addressBook.ShowAddressBook(); 
                            break;
                        case 3:
                            string owner = Console.ReadLine();
                            if (addressBook.OwnerEntry(owner))
                                AddressStarter(owner);
                            else
                                throw new AddressBookNotFoundException(owner);
                            break;
                        case 4: 
                            addressBook.SearchPersonByCityOrState(); 
                            break;
                        case 5: 
                            flag = false; 
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void AddressStarter(string name)
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("WELCOME OWNER");
                    Console.WriteLine("1. Add Contact");
                    Console.WriteLine("2. Add Contact of whole Family");
                    Console.WriteLine("3. Show Contact");
                    Console.WriteLine("4. Update Contact");
                    Console.WriteLine("5. Delete Contact");
                    Console.WriteLine("6. View by city/state");
                    Console.WriteLine("7. Count by city/state");
                    Console.WriteLine("8. Sort Alphabetically");
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
                            flag = false; 
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
