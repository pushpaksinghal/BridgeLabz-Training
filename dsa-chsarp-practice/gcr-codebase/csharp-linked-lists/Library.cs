using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.Linked_Lists
{
    class BookNode
    {
        public string Title;
        public string Author;
        public string Genre;
        public int BookId;
        public bool Available;
        public BookNode Next;
        public BookNode Prev;

        public BookNode(string title, string author, string genre, int id, bool available)
        {
            Title = title;
            Author = author;
            Genre = genre;
            BookId = id;
            Available = available;
            Next = null;
            Prev = null;
        }
    }

    class Library
    {
        BookNode head;
        BookNode tail;

        public void AddEnd(string title, string author, string genre, int id, bool available)
        {
            BookNode node = new BookNode(title, author, genre, id, available);
            if (head == null)
            {
                head = tail = node;
                return;
            }
            tail.Next = node;
            node.Prev = tail;
            tail = node;
        }

        public void RemoveById(int id)
        {
            BookNode temp = head;
            while (temp != null)
            {
                if (temp.BookId == id)
                {
                    if (temp.Prev != null)
                        temp.Prev.Next = temp.Next;
                    else
                        head = temp.Next;

                    if (temp.Next != null)
                        temp.Next.Prev = temp.Prev;
                    else
                        tail = temp.Prev;
                    return;
                }
                temp = temp.Next;
            }
        }

        public void DisplayForward()
        {
            BookNode temp = head;
            while (temp != null)
            {
                Console.WriteLine("ID " + temp.BookId + " Title " + temp.Title + " Available " + temp.Available);
                temp = temp.Next;
            }
        }

        public void DisplayReverse()
        {
            BookNode temp = tail;
            while (temp != null)
            {
                Console.WriteLine("ID " + temp.BookId + " Title " + temp.Title);
                temp = temp.Prev;
            }
        }
    }

    class Entry
    {
        static void Main()
        {
            Library lib = new Library();
            lib.AddEnd("CSharp", "MS", "Tech", 1, true);
            lib.AddEnd("Java", "Oracle", "Tech", 2, false);
            lib.DisplayForward();
            lib.DisplayReverse();
        }
    }
}

