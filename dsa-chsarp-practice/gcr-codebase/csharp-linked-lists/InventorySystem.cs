using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.Linked_Lists
{
    class ItemNode
    {
        public string Name;
        public int Id;
        public int Quantity;
        public double price;
        public ItemNode Next;

        public ItemNode(string name, int Id,int Quantity, double price)
        {
            Name = name;
            Id = Id;
            Quantity = Quantity;
            price = price;
            Next = null;
        }
    }
    internal class InventorySystem
    {
        private ItemNode head;

        public void AddBeginning(string name, int Id,int Quantity,double price)
        {
            ItemNode newNode = new ItemNode(name, Id,Quantity, price);
            newNode.Next = head;
            head = newNode;
        }

        public void AddEnd(string name, int Id, int Quantity, double price)
        {
            ItemNode newNode = new ItemNode(name, Id, Quantity, price);
            if (head == null)
            {
                head = newNode;
                return;
            }
            ItemNode current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        public void AddAtPosition(string name, int Id, int Quantity, double price, int position)
        {
            if (position == 0)
            {
                AddBeginning(name, Id, Quantity, price);
                return;
            }
            ItemNode newNode = new ItemNode(name, Id, Quantity, price);
            ItemNode current = head;
            for (int i = 0; i < position - 1 && current != null; i++)
            {
                current = current.Next;
            }
            if (current == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void DeleteByID(int Id)
        {
            if (head == null) return;
            if (head.Id ==Id)
            {
                head = head.Next;
                return;
            }
            ItemNode current = head;
            while (current.Next != null && current.Next.Id != Id)
            {
                current = current.Next;
            }
            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }

        public void UpdateId(int Id, int Quantity)
        {
            ItemNode current = head;
            while (current != null)
            {
                if (current.Id == Id)
                {
                    current.Quantity = Quantity;
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Item not found");
        }

        public void SearchByID(int Id)
        {
            ItemNode current = head;
            while (current != null)
            {
                if (current.Id == Id)
                {
                    Console.WriteLine("the item id is "+current.Id+"name is "+current.Name+"the quantity is "+current.Quantity+"the price is "+current.price);
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Item not found");
        }

        public void DisplayTotalValue()
        {
            if (head == null)
            {
                Console.WriteLine("No item in the inventory");
                return;
            }
            int total = 0;
            ItemNode temp = head;
            while (temp != null)
            {
                total += temp.Quantity * (int)temp.price;
                temp = temp.Next;
            }

            Console.WriteLine("Total inventory value: " + total);
        }

        public void SortByPrice()
        {
            for (ItemNode i = head; i != null; i = i.Next)
            {
                for (ItemNode j = i.Next; j != null; j = j.Next)
                {
                    if (i.price > j.price)
                    {
                        Swap(i, j);
                    }
                }
            }
        }
        public void SortByName()
        {
            for (ItemNode i = head; i != null; i = i.Next)
            {
                for (ItemNode j = i.Next; j != null; j = j.Next)
                {
                    if (string.Compare(i.Name, j.Name) > 0)
                    {
                        Swap(i, j);
                    }
                }
            }
        }
        private void Swap(ItemNode a, ItemNode b)
        {
            int id = a.Id;
            string name = a.Name;
            int qty = a.Quantity;
            double price = a.price;

            a.Id = b.Id;
            a.Name = b.Name;
            a.Quantity = b.Quantity;
            a.price = b.price;

            b.Id = id;
            b.Name = name;
            b.Quantity = qty;
            b.price = price;
        }
        class entry
        {
            static void Main(string[] args)
            {
                InventorySystem inventory = new InventorySystem();

                // Add items
                inventory.AddEnd("Laptop", 101, 5, 55000);
                inventory.AddEnd("Mouse", 102, 20, 500);
                inventory.AddEnd("Keyboard", 103, 10, 1500);
                inventory.AddBeginning("Monitor", 104, 7, 12000);

                Console.WriteLine("Search by ID:");
                inventory.SearchByID(102);

                Console.WriteLine("\nUpdate Quantity:");
                inventory.UpdateId(103, 15);
                inventory.SearchByID(103);

                Console.WriteLine("\nTotal Inventory Value:");
                inventory.DisplayTotalValue();

                Console.WriteLine("\nSort by Price:");
                inventory.SortByPrice();
                Display(inventory);

                Console.WriteLine("\nSort by Name:");
                inventory.SortByName();
                Display(inventory);

                Console.ReadLine();
            }

            static void Display(InventorySystem inventory)
            {
                var field = typeof(InventorySystem)
                    .GetField("head", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                ItemNode current = (ItemNode)field.GetValue(inventory);

                while (current != null)
                {
                    Console.WriteLine(
                        $"ID: {current.Id}, Name: {current.Name}, Qty: {current.Quantity}, Price: {current.price}"
                    );
                    current = current.Next;
                }
            }
        }
    }

}

