using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BridgelabzTraining.senario_based.Flash_Dealz
{
    //implementated a linked list for the list of product with quicjsort based on discount on the product
    class ProductNode
    {
        public Product product;
        public  ProductNode next;

        public ProductNode(Product p1)
        {
            product = p1;
            next = null;
        }


    }
    internal class ProductLinkedList
    {
        private ProductNode head;
        public ProductNode GetHead() { return head; }
        public void Add(Product product)
        {
            ProductNode product1 = new ProductNode(product);
            if(head == null)
            {
                head = product1;
                return;
            }
            ProductNode current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = product1;
        }

        public ProductNode QuickSort(ProductNode head)
        {
            if(head ==null || head.next == null)
            {
                return head;
            }

            ProductNode pivot = head;
            ProductNode lessHead = null;
            ProductNode greaterHead = null;
            ProductNode current = pivot.next;
            pivot.next = null;

            while(current != null)
            {
                ProductNode next = current.next;
                if (current.product.GetDiscount() > pivot.product.GetDiscount())
                {
                    current.next = lessHead;
                    lessHead = current;
                }
                else
                {
                    current.next = greaterHead;
                    greaterHead = current;
                }
                current = next;
            }

            ProductNode sortedLess = QuickSort(lessHead);
            ProductNode sortedGreater = QuickSort(greaterHead);

            ProductNode newHead = sortedLess;
            ProductNode lessTail = FindTail(sortedLess);

            if (lessTail != null)
            {
                lessTail.next = pivot;
            }
            else
            {
                newHead = pivot;
            }

            pivot.next = sortedGreater;

            return newHead;
        }

        private ProductNode FindTail(ProductNode head)
        {
            if (head == null) return null;
            while (head.next != null)
            {
                head = head.next;
            }
            return head;
        }

        public ProductNode Sort()
        {
            return QuickSort(head);
        }
    }
}
