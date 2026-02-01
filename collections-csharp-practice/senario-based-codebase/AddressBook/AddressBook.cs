using System.Collections.Generic;

namespace BridgelabzTraining.senario_based.AddressBook
{
    internal class AddressBook<T>
    {
        private string ownerName;
        private List<T> contacts;

        public AddressBook(string ownerName)
        {
            this.ownerName = ownerName;
            contacts = new List<T>();
        }

        public string OwnerName() => ownerName;
        public List<T> Contacts() => contacts;
        public int ContactCount() => contacts.Count;

        public void AddContact(T contact)
        {
            contacts.Add(contact);
        }

        public bool DeleteContactAt(int index)
        {
            if (index < 0 || index >= contacts.Count)
                return false;

            contacts.RemoveAt(index);
            return true;
        }
    }
}
