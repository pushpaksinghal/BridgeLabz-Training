using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.AddressBook
{
    internal class AddressBookNode
    {
        public AddressBook Data;
        public AddressBookNode Next;

        public AddressBookNode(AddressBook data)
        {
            Data = data;
            Next = null;
        }
    }

    internal class AddressBookLinkedList
    {
        private AddressBookNode head;
        private int count;

        public int Count() => count;
        public AddressBookNode Head() => head;

        public void Add(AddressBook book)
        {
            AddressBookNode node = new AddressBookNode(book);

            if (head == null)
            {
                head = node;
            }
            else
            {
                AddressBookNode temp = head;
                while (temp.Next != null)
                    temp = temp.Next;

                temp.Next = node;
            }
            count++;
        }
    }
}

