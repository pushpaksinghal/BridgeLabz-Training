using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stack_queue_dictionary
{
    internal class StockSpan
    {
        static void Main(string[] args)
        {
            int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
            int[] span = CalculateSpan(prices);

            foreach (int s in span)
                Console.Write(s + " ");
        }

        static int[] CalculateSpan(int[] price)
        {
            int n = price.Length;
            int[] span = new int[n];
            Stack<int> st = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                while (st.Count > 0 && price[st.Peek()] <= price[i])
                    st.Pop();

                span[i] = (st.Count == 0) ? i + 1 : i - st.Peek();
                st.Push(i);
            }
            return span;
        }
    }

}
