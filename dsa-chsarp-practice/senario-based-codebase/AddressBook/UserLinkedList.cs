using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.AddressBook
{
    internal class UserNode
    {
        public UserContact Data;
        public UserNode Next;

        public UserNode(UserContact data)
        {
            Data = data;
            Next = null;
        }
    }

    internal class UserLinkedList
    {
        private UserNode head;
        private int count;

        public int Count() => count;

        public void Add(UserContact contact)
        {
            UserNode node = new UserNode(contact);

            if (head == null)
            {
                head = node;
            }
            else
            {
                UserNode temp = head;
                while (temp.Next != null)
                    temp = temp.Next;

                temp.Next = node;
            }
            count++;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= count) return false;

            if (index == 0)
            {
                head = head.Next;
                count--;
                return true;
            }

            UserNode prev = head;
            for (int i = 0; i < index - 1; i++)
                prev = prev.Next;

            prev.Next = prev.Next.Next;
            count--;
            return true;
        }

        public UserNode Head() => head;
    }
}

