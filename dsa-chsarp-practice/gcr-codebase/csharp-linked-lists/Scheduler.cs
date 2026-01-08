using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.Linked_Lists
{
    class ProcessNode
    {
        public int Pid;
        public int Burst;
        public ProcessNode Next;

        public ProcessNode(int pid, int burst)
        {
            Pid = pid;
            Burst = burst;
            Next = null;
        }
    }

    class Scheduler
    {
        ProcessNode tail;

        public void AddProcess(int pid, int burst)
        {
            ProcessNode node = new ProcessNode(pid, burst);
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

        public void Simulate(int quantum)
        {
            ProcessNode temp = tail.Next;
            while (tail != null)
            {
                if (temp.Burst > quantum)
                {
                    Console.WriteLine("Process " + temp.Pid + " executed for " + quantum);
                    temp.Burst -= quantum;
                }
                else
                {
                    Console.WriteLine("Process " + temp.Pid + " completed");
                    Remove(temp.Pid);
                }
                temp = temp.Next;
                if (tail == null) break;
            }
        }

        public void Remove(int pid)
        {
            ProcessNode curr = tail.Next;
            ProcessNode prev = tail;
            do
            {
                if (curr.Pid == pid)
                {
                    prev.Next = curr.Next;
                    if (curr == tail)
                        tail = prev == curr ? null : prev;
                    return;
                }
                prev = curr;
                curr = curr.Next;
            } while (curr != tail.Next);
        }
    }

    class Entry
    {
        static void Main()
        {
            Scheduler s = new Scheduler();
            s.AddProcess(1, 10);
            s.AddProcess(2, 5);
            s.AddProcess(3, 8);
            s.Simulate(3);
        }
    }
}

