using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.Linked_Lists
{
    class TextNode
    {
        public string Text;
        public TextNode Next;
        public TextNode Prev;

        public TextNode(string text)
        {
            Text = text;
        }
    }

    class Editor
    {
        TextNode current;

        public void AddState(string text)
        {
            TextNode node = new TextNode(text);
            if (current != null)
            {
                current.Next = node;
                node.Prev = current;
            }
            current = node;
        }

        public void Undo()
        {
            if (current != null && current.Prev != null)
                current = current.Prev;
            Console.WriteLine("Current text " + current.Text);
        }

        public void Redo()
        {
            if (current != null && current.Next != null)
                current = current.Next;
            Console.WriteLine("Current text " + current.Text);
        }
    }

    class Entry
    {
        static void Main()
        {
            Editor e = new Editor();
            e.AddState("Hello");
            e.AddState("Hello World");
            e.Undo();
            e.Redo();
        }
    }
}

