using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.Linked_Lists
{
    class TaskNode
    {
        public int TaskId;
        public string TaskName;
        public int Priority;
        public string DueDate;
        public TaskNode Next;

        public TaskNode(int taskId, string taskName, int priority, string dueDate)
        {
            TaskId = taskId;
            TaskName = taskName;
            Priority = priority;
            DueDate = dueDate;
            Next = this;
        }
    }

    class Task
    {
        private TaskNode head;
        private TaskNode current;

        // Add at Beginning
        public void AddAtBeginning(int id, string name, int priority, string dueDate)
        {
            TaskNode newNode = new TaskNode(id, name, priority, dueDate);

            if (head == null)
            {
                head = current = newNode;
                return;
            }

            TaskNode last = head;
            while (last.Next != head)
                last = last.Next;

            newNode.Next = head;
            last.Next = newNode;
            head = newNode;
        }

        // Add at End
        public void AddAtEnd(int id, string name, int priority, string dueDate)
        {
            TaskNode newNode = new TaskNode(id, name, priority, dueDate);

            if (head == null)
            {
                head = current = newNode;
                return;
            }

            TaskNode temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = newNode;
            newNode.Next = head;
        }

        // Add at Specific Position
        public void AddAtPosition(int position, int id, string name, int priority, string dueDate)
        {
            if (position <= 1)
            {
                AddAtBeginning(id, name, priority, dueDate);
                return;
            }

            TaskNode temp = head;
            for (int i = 1; i < position - 1 && temp.Next != head; i++)
                temp = temp.Next;

            TaskNode newNode = new TaskNode(id, name, priority, dueDate);
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        // Remove by Task ID
        public void RemoveById(int id)
        {
            if (head == null)
            {
                Console.WriteLine("Task list is empty");
                return;
            }

            TaskNode temp = head;
            TaskNode prev = null;

            do
            {
                if (temp.TaskId == id)
                {
                    if (temp == head)
                    {
                        // Single node case
                        if (head.Next == head)
                        {
                            head = current = null;
                        }
                        else
                        {
                            TaskNode last = head;
                            while (last.Next != head)
                                last = last.Next;

                            head = head.Next;
                            last.Next = head;
                        }
                    }
                    else
                    {
                        prev.Next = temp.Next;
                    }

                    Console.WriteLine("Task removed successfully");
                    return;
                }

                prev = temp;
                temp = temp.Next;

            } while (temp != head);

            Console.WriteLine("Task not found");
        }

        // View Current Task and Move to Next
        public void ViewNextTask()
        {
            if (current == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            Console.WriteLine("ID:"+current.TaskId+", Name: "+current.TaskName+", Priority: "+current.Priority+", Due: "+current.DueDate);
            current = current.Next;
        }

        // Display All Tasks
        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            TaskNode temp = head;
            do
            {
                Console.WriteLine("ID: "+temp.TaskId+", Name: "+temp.TaskName+", Priority: "+temp.Priority+", Due: "+temp.DueDate);
                temp = temp.Next;
            } while (temp != head);
        }

        // Search by Priority
        public void SearchByPriority(int priority)
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            TaskNode temp = head;
            bool found = false;

            do
            {
                if (temp.Priority==priority)
                {
                    Console.WriteLine("ID:"+temp.TaskId+", Name: "+temp.TaskName+", Due: "+temp.DueDate);
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
                Console.WriteLine("No tasks found with this priority");
        }

        static void Main(string[] args)
        {
            Task tasks = new Task();

            Console.WriteLine("Enter number of tasks: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter details for task {i + 1}:");

                int id = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                int priority = Convert.ToInt32(Console.ReadLine());
                string dueDate = Console.ReadLine();

                tasks.AddAtEnd(id, name, priority, dueDate);
            }

            Console.WriteLine("\nAll Tasks:");
            tasks.DisplayAll();

            Console.WriteLine("Viewing tasks one by one (Circular):");
            for (int i = 0; i < n; i++)
                tasks.ViewNextTask();

            Console.WriteLine("Enter priority to search: ");
            int searchPriority = Convert.ToInt32(Console.ReadLine());
            tasks.SearchByPriority(searchPriority);

            Console.WriteLine("Enter Task ID to remove: ");
            int removeId = Convert.ToInt32(Console.ReadLine());
            tasks.RemoveById(removeId);

            Console.WriteLine("\nTasks after removal:");
            tasks.DisplayAll();
        }
    }
}


