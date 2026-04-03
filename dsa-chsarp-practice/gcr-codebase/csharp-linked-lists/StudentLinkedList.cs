using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.Linked_Lists
{
    class StudentNode
    {
        public int RollNo;
        public string Name;
        public int Age;
        public char Grade;
        public StudentNode Next;

        public StudentNode(int rollNo, string name, int age, char grade)
        {
            RollNo = rollNo;
            Name = name;
            Age = age;
            Grade = grade;
            Next = null;
        }
    }
    class StudentLinkedList
    {
        private StudentNode head;

        public void AddBeginning(int rollNo, string name, int age, char grade)
        {
            StudentNode newNode = new StudentNode(rollNo, name, age, grade);
            newNode.Next = head;
            head = newNode;
        }

        public void AddEnd(int rollNo, string name, int age, char grade)
        {
            StudentNode newNode = new StudentNode(rollNo, name, age, grade);
            if (head == null)
            {
                head = newNode;
                return;
            }
            StudentNode current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void AddAtPosition(int rollNo, string name, int age, char grade, int position)
        {
            if (position == 0)
            {
                AddBeginning(rollNo, name, age, grade);
                return;
            }
            StudentNode newNode = new StudentNode(rollNo, name, age, grade);
            StudentNode current = head;
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

        public void DeleteByRollNo(int rollNo)
        {
            if (head == null) return;
            if (head.RollNo == rollNo)
            {
                head = head.Next;
                return;
            }
            StudentNode current = head;
            while (current.Next != null && current.Next.RollNo != rollNo)
            {
                current = current.Next;
            }
            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }

        public void SearchByRollNo(int rollNo)
        {
            StudentNode current = head;
            while (current != null)
            {
                if (current.RollNo == rollNo)
                {
                    Console.WriteLine("Found: Roll No:" + current.RollNo + ", Name: " + current.Name + ", Age:" + current.Age + ", Grade:" + current.Grade);
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Student not found");
        }

        public void UpdateGrade(int rollNo, char grade)
        {
            StudentNode current = head;
            while (current != null)
            {
                if (current.RollNo == rollNo)
                {
                    current.Grade = grade;
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Student not found");
        }

        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("No student records available");
                return;
            }

            StudentNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"Roll No: {temp.RollNo}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
                temp = temp.Next;
            }
        }
    }

    class entry
    {
        static void Main(string[] args)
        {
            StudentLinkedList list = new StudentLinkedList();

            list.AddBeginning(101, "Aman", 20, 'A');
            list.AddEnd(102, "Riya", 21, 'B');
            list.AddAtPosition(103, "Karan", 19, 'A', 2);

            Console.WriteLine("\nAll Student Records:");
            list.DisplayAll();

            Console.WriteLine("\nSearch Roll No 102:");
            list.SearchByRollNo(102);

            Console.WriteLine("\nUpdate Grade for Roll No 101:");
            list.UpdateGrade(101, 'A');

            Console.WriteLine("\nDelete Roll No 103:");
            list.DeleteByRollNo(103);

            Console.WriteLine("\nFinal Student Records:");
            list.DisplayAll();
        }
    }
}
