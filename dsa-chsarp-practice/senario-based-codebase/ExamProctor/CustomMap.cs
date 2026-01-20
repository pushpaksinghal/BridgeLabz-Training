using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProctor
{
    class Node
    {
        public int Key;
        public string Value;
        public Node Next;

        public Node(int k, string v)
        {
            Key = k;
            Value = v;
        }
    }
    class AnswerMap
    {
        //Array of buckets
        private Node[] buckets = new Node[10];

        private int Hash(int key) => key % 10;

        public void Put(int key, string value)
        {
            int idx = Hash(key);
            Node node = new Node(key, value);

            // If bucket empty, insert directly
            if (buckets[idx] == null)
            {
                buckets[idx] = node;
                return;
            }

            //else add to end of linked list
            Node temp = buckets[idx];
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = node;
        }

        // Get answer for a question
        public string Get(int key)
        {
            int idx = Hash(key);
            Node temp = buckets[idx];

            while (temp != null)
            {
                if (temp.Key == key) return temp.Value;
                temp = temp.Next;
            }
            return null;
        }
    }
}
