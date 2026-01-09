using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stack_queue_dictionary
{
    internal class CustomHashMap
    {
        class Node
        {
            public int key, value;
            public Node next;
        }

        private Node[] table = new Node[10];

        int Hash(int key) => key % table.Length;

        public void Put(int key, int value)
        {
            int index = Hash(key);
            Node node = new Node { key = key, value = value, next = table[index] };
            table[index] = node;
        }

        public int Get(int key)
        {
            int index = Hash(key);
            Node current = table[index];

            while (current != null)
            {
                if (current.key == key)
                    return current.value;
                current = current.next;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            CustomHashMap map = new CustomHashMap();
            map.Put(1, 100);
            map.Put(11, 200);
            Console.WriteLine(map.Get(11));
        }
    }

}
