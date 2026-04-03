using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stack_queue_dictionary
{
    internal class SortStackRecursion
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(3);
            stack.Push(1);
            stack.Push(4);  
            stack.Push(2);
            Sort(stack);
            while (stack.Count > 0)
                Console.WriteLine(stack.Pop());
        }
        static void Sort(Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                int temp = stack.Pop();
                Sort(stack);
                InsertSorted(stack, temp);
            }
        }
        static void InsertSorted(Stack<int> stack, int x)
        {
            if (stack.Count == 0 || x > stack.Peek())
            {
                stack.Push(x);
                return;
            }

            int temp = stack.Pop();
            InsertSorted(stack, x);
            stack.Push(temp);
        }
    }

}
