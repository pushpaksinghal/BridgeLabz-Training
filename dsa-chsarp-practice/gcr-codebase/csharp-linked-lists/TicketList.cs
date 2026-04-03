using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.Linked_Lists
{
    class TicketNode
    {
        public int TicketId;
        public string Customer;
        public TicketNode Next;

        public TicketNode(int id, string customer)
        {
            TicketId = id;
            Customer = customer;
            Next = null;
        }
    }

    class TicketList
    {
        TicketNode tail;

        public void AddTicket(int id, string customer)
        {
            TicketNode node = new TicketNode(id, customer);
            if (tail == null)
            {
                tail = node;
                tail.Next = tail;
                return;
            }
            node.Next = tail.Next;
            tail.Next = node;
            tail = node;
        }

        public void Display()
        {
            if (tail == null) return;
            TicketNode temp = tail.Next;
            do
            {
                Console.WriteLine("Ticket " + temp.TicketId + " Customer " + temp.Customer);
                temp = temp.Next;
            } while (temp != tail.Next);
        }
    }

    class Entry
    {
        static void Main()
        {
            TicketList t = new TicketList();
            t.AddTicket(1, "John");
            t.AddTicket(2, "Emma");
            t.Display();
        }
    }
}

