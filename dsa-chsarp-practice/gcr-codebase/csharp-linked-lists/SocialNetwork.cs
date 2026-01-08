using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.Linked_Lists
{
    class UserNode
    {
        public int Id;
        public string Name;
        public UserNode Next;

        public UserNode(int id, string name)
        {
            Id = id;
            Name = name;
            Next = null;
        }
    }

    class SocialNetwork
    {
        UserNode head;

        public void AddUser(int id, string name)
        {
            UserNode node = new UserNode(id, name);
            node.Next = head;
            head = node;
        }

        public void SearchById(int id)
        {
            UserNode temp = head;
            while (temp != null)
            {
                if (temp.Id == id)
                {
                    Console.WriteLine("Found user " + temp.Name);
                    return;
                }
                temp = temp.Next;
            }
        }
    }

    class Entry
    {
        static void Main()
        {
            SocialNetwork sn = new SocialNetwork();
            sn.AddUser(1, "Alice");
            sn.AddUser(2, "Bob");
            sn.SearchById(2);
        }
    }
}

