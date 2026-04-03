using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BridgelabzTraining.senario_based.AddressBook
{
    public interface IAddressBook
    {
        void AddAddressBook(string ownerName);
        // making AddContact method signature
        List<string> GetAllAddressBookOwners();
        bool OwnerEntry(string ownerName);
        void AddContact(string ownerName, UserContact contact);
        // making the method signature for adding multiple contacts
        void AddContactsOfFamily(string ownerName, List<UserContact> contacts);
        List<UserContact> GetContacts(string ownerName);
        // for UC-3 editing contact method signature
        void EditContact(string ownerName, string firstName, string lastName, UserContact updatedContact);
        // for UC-4 deleting contact method signature
        void DeleteContact(string ownerName, string firstName, string lastName);
        // for Uc-8 searching person by city or state accross multiple address book
        List<(string Owner, UserContact Contact)> SearchAcrossBooks(string firstName, string cityOrState);
        // for UC-9 viewing person by city or state accross multiple address book
        List<UserContact> FilterByCityOrState(string ownerName, string cityOrState);
        // for UC-10 counting person by city or state accross multiple address book
        int CountByCityOrState(string ownerName, string cityOrState);
        // for UC-11 sorting contacts alphabetically
        void SortContactsAlphabetically(string ownerName);

        //for UC-12 sorting 
        void SortContactsByCity(string ownerName);
        void SortContactsByState(string ownerName);
        void SortContactsByZip(string ownerName);

        // for UC-13 File I/O
        void SaveAddressBookToFile(string ownerName, string filePath);
        void LoadAddressBookFromFile(string ownerName, string filePath);

        //for UC-14 File CSV
        void ExportToCsv(string ownerName, string filePath);
        void ImportFromCsv(string ownerName, string filePath);

        //For UC-15 File JSON
        void ExportToJson(string ownerName, string filePath);
        void ImportFromJson(string ownerName, string filePath);


    }
}
